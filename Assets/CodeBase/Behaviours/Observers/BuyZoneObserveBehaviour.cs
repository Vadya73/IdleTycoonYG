using Atomic.Contexts;
using Atomic.Elements;
using Atomic.Entities;
using CodeBase.Contexts;
using CodeBase.Installers;
using UnityEngine;

namespace CodeBase.Behaviours.Observers
{
    public sealed class BuyZoneObserveBehaviour : IEntityInit, IEntityDispose
    {
        private BaseEvent<Collider> _triggerEvent;
        private PurchaseCheckBehaviour _purchaseChecker;

        void IEntityInit.Init(IEntity entity)
        {
            _triggerEvent = entity.GetOnTriggerEnterAction();
            _purchaseChecker = entity.GetBehaviour<PurchaseCheckBehaviour>();

            _triggerEvent.Subscribe(TryPurchase);
        }

        void IEntityDispose.Dispose(IEntity entity)
        {
            _triggerEvent.Unsubscribe(TryPurchase);
        }

        private void TryPurchase(Collider triggerCollider)
        {
            if (triggerCollider.TryGetComponent(out PlayerInstaller playerInstaller))
                _purchaseChecker.Purchase();
        }
    }

    public sealed class BuildBehaviour : IEntityInit
    {
        private GameObject _prefabBuilding;
        private Transform _buildTransform;
        
        public void Init(IEntity entity)
        {
            
        }
    }

    public sealed class PurchaseCheckBehaviour : IEntityInit
    {
        private WalletType _walletType;
        private ReactiveVariable<int> _cost;
        private BaseEvent OnPurchase;

        private ReactiveVariable<int> _currentWalletCoins;
        private ReactiveVariable<int> _currentWalletDiamonds;
        
        private IEntity _walletEntity;

        void IEntityInit.Init(IEntity entity)
        {
            _walletType = entity.GetWalletType();
            _cost = entity.GetCost();
            
            _walletEntity = AppContext.Instance.GetWallet().GetComponent<IEntity>();
            
            _currentWalletCoins = _walletEntity.GetCoins();
            _currentWalletDiamonds = _walletEntity.GetDiamonds();
        }

        public void Purchase()
        {
            if (!CanPurchase()) 
                return;
            
            if (_walletType == WalletType.Coin)
            {
                _currentWalletCoins.Value -= _cost.Value;
                OnPurchase.Invoke();
            }
            else if (_walletType == WalletType.Diamond)
            {
                _currentWalletDiamonds.Value -= _cost.Value;
                OnPurchase.Invoke();
            }
        }

        private bool CanPurchase()
        {
            if (_walletType == WalletType.Coin && _currentWalletCoins.Value >= _cost.Value)
                return true;
            if (_walletType == WalletType.Diamond && _currentWalletDiamonds.Value >= _cost.Value)
                return true;

            return false;
        }
    }
}