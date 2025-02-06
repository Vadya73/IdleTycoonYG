using Atomic.Contexts;
using Atomic.Elements;
using Atomic.Entities;
using CodeBase.Contexts;
using Cysharp.Threading.Tasks;

namespace CodeBase.Behaviours
{
    public sealed class PurchaseCheckBehaviour : IEntityInit
    {
        private WalletType _walletType;
        private ReactiveVariable<int> _cost;
        private BaseEvent OnPurchaseEvent;
        private WaitProgressBehaviour _waitProgressBehaviour;

        private ReactiveVariable<int> _currentWalletCoins;
        private ReactiveVariable<int> _currentWalletDiamonds;
        
        private IEntity _walletEntity;

        void IEntityInit.Init(IEntity entity)
        {
            _waitProgressBehaviour = entity.GetBehaviour<WaitProgressBehaviour>();
            OnPurchaseEvent = entity.GetOnPurchaseEvent();
            _walletType = entity.GetWalletType();
            _cost = entity.GetCost();
            
            _walletEntity = AppContext.Instance.GetWallet().GetComponent<IEntity>();
            
            _currentWalletCoins = _walletEntity.GetCoins();
            _currentWalletDiamonds = _walletEntity.GetDiamonds();
        }

        public async UniTask Purchase()
        {
            if (!CanPurchase()) 
                return;
            
            var success = await _waitProgressBehaviour.StartWaitProgress();
            if (!success)
                return;
            
            if (_walletType == WalletType.COIN)
                _currentWalletCoins.Value -= _cost.Value;
            else if (_walletType == WalletType.DIAMOND)
                _currentWalletDiamonds.Value -= _cost.Value;
            
            OnPurchaseEvent.Invoke();
        }

        private bool CanPurchase()
        {
            if (_walletType == WalletType.COIN && _currentWalletCoins.Value >= _cost.Value)
                return true;
            if (_walletType == WalletType.DIAMOND && _currentWalletDiamonds.Value >= _cost.Value)
                return true;

            return false;
        }
    }
}