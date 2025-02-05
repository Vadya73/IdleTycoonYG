using Atomic.Contexts;
using Atomic.Elements;
using Atomic.Entities;
using CodeBase.Contexts;
using CodeBase.Installers;
using UnityEngine;

namespace CodeBase.Behaviours
{
    public class WorthReceiveBehaviour : IEntityInit
    {
        private WalletType _walletType;
        private ReactiveVariable<int> _worth;
        private DestroyGameObjectBehaviour _destroyGameObjectBehaviour;
        
        public void Init(IEntity entity)
        {
            _walletType = entity.GetWalletType();
            _worth = entity.GetWorth();
            _destroyGameObjectBehaviour = entity.GetBehaviour<DestroyGameObjectBehaviour>();
        }

        public void Receive()
        { 
            AppContext.Instance.GetWallet().AddWalletWorth(_walletType, _worth);
            _destroyGameObjectBehaviour.DestroyObject();
        }
    }
}