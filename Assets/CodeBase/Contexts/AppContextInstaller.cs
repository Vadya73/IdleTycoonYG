using Atomic.Contexts;
using UnityEngine;

namespace CodeBase.Contexts
{
    public class AppContextInstaller : SceneContextInstallerBase
    {
        [SerializeField] private Wallet _wallet;
        public override void Install(IContext context)
        {
            context.AddWallet(_wallet);
        }
    }
}