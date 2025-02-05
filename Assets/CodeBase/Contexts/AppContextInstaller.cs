using Atomic.Contexts;
using UnityEngine;
using UnityEngine.Serialization;

namespace CodeBase.Contexts
{
    public class HuiuContext : MonoBehaviour
    {
        [SerializeField] private WalletInstaller _walletInstaller;
        private void Awake()
        {
           _walletInstaller = AppContext.Instance.GetWallet();
        }
    }
    public class AppContextInstaller : SceneContextInstallerBase
    {
        [SerializeField] private WalletInstaller _walletInstaller;
        public override void Install(IContext context)
        {
            context.AddWallet(_walletInstaller);
        }
    }
}