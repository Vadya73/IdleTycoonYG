using Atomic.Elements;
using Atomic.Entities;
using CodeBase.Behaviours;
using UnityEngine;

namespace CodeBase
{
    public sealed class ResourceMineBehaviour : IEntityInit, IEntityFixedUpdate
    {
        private ReactiveVariable<bool> _canMine;
        private ReactiveVariable<bool> _isMoving;
        private Transform _mineObjectTransform;

        private AnimationBehaviour _animationBehaviour;
        private RotateBehaviour _rotateBehaviour;

        public void Init(IEntity entity)
        {
            _animationBehaviour = entity.GetBehaviour<AnimationBehaviour>();
            _rotateBehaviour = entity.GetBehaviour<RotateBehaviour>();
            
            _canMine = entity.GetCanMine();
            _isMoving = entity.GetIsMoving();
        }

        public void OnFixedUpdate(IEntity entity, float deltaTime)
        {
            Mine();
        }

        public void SetMineObjectTransform(Transform transform)
        {
            _mineObjectTransform = transform;
        }

        private void Mine()
        {
            if (!_canMine.Value && _isMoving.Value)
                return;

            _rotateBehaviour.SetDirectionValue(_mineObjectTransform.position);
            _animationBehaviour.PlayAnimation(animationKey: "Mine");
        }
    }
}