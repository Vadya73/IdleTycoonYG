using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace CodeBase
{
    public class Wallet : SceneEntityInstallerBase
    {
        public ReactiveVariable<int> Coins => _coins;
        [SerializeField] private ReactiveVariable<int> _coins;
        
        public ReactiveVariable<int> Diamonds => _diamonds;
        [SerializeField] private ReactiveVariable<int> _diamonds;

        private IEntity _entity;
        
        public override void Install(IEntity entity)
        {
            _entity = entity;

            entity.AddCoins(_coins);
            entity.AddDiamonds(_diamonds);
        }

        public void AddWalletWorth(WalletType walletType, ReactiveVariable<int> worth)
        {
            if (walletType == WalletType.COIN)
                _coins.Value += worth.Value;
            else if (walletType == WalletType.DIAMOND)
                _diamonds.Value += worth.Value;
        }
    }
}