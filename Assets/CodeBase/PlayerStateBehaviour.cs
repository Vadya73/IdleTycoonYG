using Atomic.Elements;
using Atomic.Entities;

namespace CodeBase
{
    public sealed class PlayerStateBehaviour : IEntityInit
    {
        private ReactiveVariable<bool> _canMine;
        private ReactiveVariable<bool> _isMoving;
        
        public void Init(IEntity entity)
        {
            _canMine = entity.GetCanMine();
            _isMoving = entity.GetIsMoving();
        }

        public void SetMovingTrue() => _isMoving = true;

        public void SetMovingFalse() => _isMoving = false;

        public void SetMiningTrue() => _canMine.Value = true;
        
        public void SetMiningFalse() => _canMine.Value = false;
    }
}