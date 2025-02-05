using Atomic.Elements;
using Atomic.Entities;
using CodeBase.Behaviours;
using CodeBase.Behaviours.Observers;
using UnityEngine;

namespace CodeBase.Installers
{
    public class СurrencyInstaller : SceneEntityInstallerBase
    {
        [SerializeField] private GameObject _objectToDestroy;
        [SerializeField] private WalletType _walletType;
        [SerializeField] private ReactiveVariable<int> _worth;
        
        public override void Install(IEntity entity)
        {
            if (_objectToDestroy == null)
                _objectToDestroy = this.gameObject;
            
            entity.AddWalletType(_walletType);
            entity.AddWorth(_worth);
            entity.AddDestroyObject(_objectToDestroy);

            entity.AddBehaviour(new WorthReceiveBehaviour());
            entity.AddBehaviour(new CoinObserveBehaviour());
            entity.AddBehaviour(new DestroyGameObjectBehaviour());
        }
    }
}