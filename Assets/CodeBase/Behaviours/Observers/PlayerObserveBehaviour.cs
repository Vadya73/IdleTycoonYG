using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace CodeBase.Behaviours.Observers
{
    public sealed class PlayerObserveBehaviour : IEntityInit, IEntityDispose
    {
        private BaseEvent<Vector2> _moveEvent;
        private MovementBehaviour _movementBehaviour;
        private RotateBehaviour _rotateBehaviour;
        
        public void Init(IEntity entity)
        {
            _moveEvent = entity.GetOnMoveAction();
            // Rotate
            _rotateBehaviour = entity.GetBehaviour<RotateBehaviour>();
            _moveEvent.Subscribe(_rotateBehaviour.SetDirectionValue);
            // Move
            _movementBehaviour = entity.GetBehaviour<MovementBehaviour>();
            _moveEvent.Subscribe(_movementBehaviour.SetDirectionValue);
        }

        public void Dispose(IEntity entity)
        {
            _moveEvent.Unsubscribe(_movementBehaviour.SetDirectionValue);
            _moveEvent.Unsubscribe(_rotateBehaviour.SetDirectionValue);
        }
    }
}