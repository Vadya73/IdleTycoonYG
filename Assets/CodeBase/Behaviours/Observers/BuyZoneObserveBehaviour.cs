using Atomic.Elements;
using Atomic.Entities;
using CodeBase.Installers;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace CodeBase.Behaviours.Observers
{
    public sealed class BuyZoneObserveBehaviour : IEntityInit, IEntityDispose
    {
        private BaseEvent<Collider> OnTriggerEnterEvent;
        private BaseEvent<Collider> OnTriggerExitEvent;

        private BaseEvent OnProgressStart;
        private BaseEvent OnProgressCancel;
        
        private PurchaseCheckBehaviour _purchaseChecker;
        private WaitProgressBehaviour _waitProgressBehaviour;
        private ShowUIProgressBehaviour _showUIProgressBehaviour;
        
        private bool _isPurchasing = false;

        void IEntityInit.Init(IEntity entity)
        {
            OnTriggerEnterEvent = entity.GetOnTriggerEnterAction();
            OnTriggerExitEvent = entity.GetOnTriggerExitAction();
            
            OnProgressStart = entity.GetOnProgressStart();
            OnProgressCancel = entity.GetOnProgressCancel();
                
            _purchaseChecker = entity.GetBehaviour<PurchaseCheckBehaviour>();
            _waitProgressBehaviour = entity.GetBehaviour<WaitProgressBehaviour>();
            _showUIProgressBehaviour = entity.GetBehaviour<ShowUIProgressBehaviour>();

            OnTriggerEnterEvent.Subscribe(TryPurchase);
            OnTriggerExitEvent.Subscribe(CancelPurchase);

            OnProgressStart.Subscribe(StartUIProgress);
            OnProgressCancel.Subscribe(StopUIProgress);
        }

        private void StartUIProgress()
        {
            _showUIProgressBehaviour.StartUIProgress();
        }

        private void StopUIProgress()
        {
            _showUIProgressBehaviour.StopUIProgress();
        }

        void IEntityDispose.Dispose(IEntity entity)
        {
            OnTriggerEnterEvent.Unsubscribe(TryPurchase);
            OnTriggerExitEvent.Unsubscribe(CancelPurchase);
        }

        private void TryPurchase(Collider triggerCollider)
        {
            TryPurchaseAsync(triggerCollider).Forget();
        }

        private async UniTaskVoid TryPurchaseAsync(Collider triggerCollider)
        {
            _isPurchasing = true;
            
            if (triggerCollider.TryGetComponent(out PlayerInstaller playerInstaller))
                await _purchaseChecker.Purchase();

            _isPurchasing = false;
        }

        private void CancelPurchase(Collider triggerCollider)
        {
            if (triggerCollider.TryGetComponent(out PlayerInstaller playerInstaller) && _isPurchasing)
                _waitProgressBehaviour.CancelWaitProgress();
        }
    }
}