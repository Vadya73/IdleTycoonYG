using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;
using UnityEngine.Serialization;

namespace CodeBase.Installers
{
    public class BuyZoneInstaller : SceneEntityInstallerBase
    {
        [SerializeField] private GameObject _buildPrefab;
        [SerializeField] private WalletType _walletType;
        [SerializeField] private ReactiveVariable<int> _cost;
        public override void Install(IEntity entity)
        {
            entity.AddBuildPrefab(_buildPrefab);
            entity.AddWalletType(_walletType);
            entity.AddCost(_cost);
        }
    }
}