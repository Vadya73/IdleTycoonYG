using System;
using System.Threading;
using Atomic.Elements;
using Atomic.Entities;
using Cysharp.Threading.Tasks;

namespace CodeBase.Behaviours
{
    public class WaitProgressBehaviour : IEntityInit
    {
        private BaseEvent OnProgressStart;
        private BaseEvent OnProgressCancel;
        
        private ReactiveVariable<int> _secondsForWait;
        private int _milSecondsForWait;
        private const int MilSecondsMultiplier = 1000;
        
        private CancellationTokenSource _waitProgressCts;
        
        public void Init(IEntity entity)
        {
            OnProgressStart = entity.GetOnProgressStart();
            OnProgressCancel = entity.GetOnProgressCancel();
            
            _secondsForWait = entity.GetSecondsForWaiting();
            
            int seconds = _secondsForWait.Value;
            _milSecondsForWait = seconds *= MilSecondsMultiplier;
        }
        
        public async UniTask<bool> StartWaitProgress()
        {
            CancelWaitProgress();
            
            _waitProgressCts = new CancellationTokenSource();
            
            try
            {
                OnProgressStart.Invoke();
                await UniTask.Delay(_milSecondsForWait, cancellationToken: _waitProgressCts.Token);
                OnProgressCancel.Invoke();
                return true;
            }
            catch (OperationCanceledException)
            {
                OnProgressCancel.Invoke();
                return false;
            }
        }

        public void CancelWaitProgress()
        {
            if (_waitProgressCts == null || _waitProgressCts.IsCancellationRequested)
                return;
            
            OnProgressCancel.Invoke();
            _waitProgressCts.Cancel();
            _waitProgressCts.Dispose();
            _waitProgressCts = null;
        }

    }
}