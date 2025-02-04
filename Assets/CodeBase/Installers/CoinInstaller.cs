using Atomic.Elements;
using Atomic.Entities;
using CodeBase.Behaviours;
using UnityEngine;

namespace CodeBase.Installers
{
    public class CoinInstaller : SceneEntityInstallerBase
    {
        [SerializeField] private ReactiveVariable<int> _worth;
        
        public override void Install(IEntity entity)
        {
            entity.AddWorth(_worth);

            entity.AddBehaviour(new WorthReceiveBehaviour());
        }
    }
}