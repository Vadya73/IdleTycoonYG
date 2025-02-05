using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace CodeBase.Behaviours
{
    public sealed class RotateBehaviour : IEntityInit, IEntityUpdate
    {
        private Transform _rotateRoot;
        private ReactiveVariable<Vector3> _rotateDirection;
        private ReactiveVariable<float> _rotateSpeed;
        public void Init(IEntity entity)
        {
            _rotateRoot = entity.GetRotateRoot();
            _rotateDirection = entity.GetRotateDirection();
            _rotateSpeed = entity.GetRotateSpeed();
        }

        public void OnUpdate(IEntity entity, float deltaTime)
        {
            if (_rotateDirection.Value != Vector3.zero)
            {
                Rotate(deltaTime);
                _rotateDirection.Value = Vector3.zero;
            }
        }

        public void SetDirectionValue(Vector2 direction)
        {
            Vector3 rotateDirectionValue = new Vector3(direction.x, 0, direction.y);
            _rotateDirection.Value = rotateDirectionValue;
        }

        private void Rotate(float deltaTime)
        {
            Quaternion targetRotation = Quaternion.LookRotation(_rotateDirection.Value, Vector3.up);
            _rotateRoot.rotation = Quaternion.Lerp(_rotateRoot.rotation, targetRotation, _rotateSpeed.Value * deltaTime);
        }
    }
}