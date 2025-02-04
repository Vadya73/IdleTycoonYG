using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace CodeBase.Behaviours
{
    public sealed class MovementBehaviour : IEntityInit, IEntityUpdate
    {
        private Transform _root;
        private ReactiveVariable<float> _moveSpeed;
        private ReactiveVariable<Vector3> _moveDirection;
        
        void IEntityInit.Init(IEntity entity)
        {
            _root = entity.GetRoot();
            _moveSpeed = entity.GetMoveSpeed();
            _moveDirection = entity.GetMoveDirection();

            var inputAction = entity.GetOnMoveAction();
            inputAction.Subscribe(SetDirectionValue);
        }

        void IEntityUpdate.OnUpdate(IEntity entity, float deltaTime)
        {
            if (_moveDirection.Value != Vector3.zero)
            {
                this.Move(deltaTime);
                _moveDirection.Value = Vector3.zero;
            }
        }

        private void Move(float deltaTime)
        {
            var targetPosition = _root.position + _moveDirection.Value * (_moveSpeed.Value * deltaTime);
            _root.position = Vector3.MoveTowards(_root.position, targetPosition, 0.2f);
        }

        public void SetDirectionValue(Vector2 direction)
        {
            var directionX = direction.x;
            var directionZ = direction.y;
            _moveDirection.Value = new Vector3(directionX, 0, directionZ);
        }
    }
}