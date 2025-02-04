using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace CodeBase.Behaviours
{
    public sealed class FollowBehaviour : IEntityInit, IEntityLateUpdate
    {
        private Transform _currentTransform;
        private Transform _followTarget;
        private ReactiveVariable<Vector3> _followOffset;
        private ReactiveVariable<float> _followSpeed;
            
        public void Init(IEntity entity)
        {
            _currentTransform = entity.GetCurrentTransform();
            _followTarget = entity.GetFollowTarget();
            _followOffset = entity.GetFollowOffset();
            _followSpeed = entity.GetFollowSpeed();
        }

        public void OnLateUpdate(IEntity entity, float deltaTime)
        {
            var newPosition = _followTarget.position + _followOffset.Value;
            _currentTransform.position = Vector3.Lerp(_currentTransform.position, newPosition, _followSpeed.Value * deltaTime);
        }
    }
}