using Atomic.Elements;
using Atomic.Entities;
using CodeBase.Installers;
using UnityEngine;

namespace CodeBase.Behaviours.Observers
{
    public class CoinObserveBehaviour : IEntityInit, IEntityDispose
    {
        private BaseEvent<Collider> _triggerEvent;
        private WorthReceiveBehaviour _worthReceiveBehaviour;
            
        public void Init(IEntity entity)
        {
            _triggerEvent = entity.GetOnTriggerEnterAction();
            _worthReceiveBehaviour = entity.GetBehaviour<WorthReceiveBehaviour>();

            _triggerEvent.Subscribe(Receive);
        }

        public void Dispose(IEntity entity)
        {
            _triggerEvent.Unsubscribe(Receive);
        }

        private void Receive(Collider collidedObject)
        {
            if (collidedObject.TryGetComponent(out PlayerInstaller playerInstaller))
                _worthReceiveBehaviour.Receive();
        }
    }
}