using Atomic.Elements;
using Atomic.Entities;
using CodeBase.Installers;
using UnityEngine;

namespace CodeBase
{
    public class ResourceObjectObserveBehaviour : IEntityInit, IEntityDispose
    {
        private BaseEvent<Collider> OnTriggetEnterEvent;
        private BaseEvent<Collider> OnTriggetExitEvent;

        private Transform _currentTransform;

        public void Init(IEntity entity)
        {
            _currentTransform = entity.GetCurrentTransform();
            
            OnTriggetEnterEvent = entity.GetOnTriggerEnterAction();
            OnTriggetExitEvent = entity.GetOnTriggerExitAction();

            OnTriggetEnterEvent.Subscribe(SetTrueMining);
            OnTriggetExitEvent.Subscribe(SetFalseMining);
        }

        public void Dispose(IEntity entity)
        {
            OnTriggetEnterEvent.Unsubscribe(SetTrueMining);
            OnTriggetExitEvent.Unsubscribe(SetFalseMining);
        }

        private void SetTrueMining(Collider obj)
        {
            if (obj.TryGetComponent(out PlayerInstaller playerInstaller))
            {
                playerInstaller.CurrentEntity.GetBehaviour<PlayerStateBehaviour>().SetMiningTrue();
                playerInstaller.CurrentEntity.GetBehaviour<ResourceMineBehaviour>().SetMineObjectTransform(_currentTransform);
            }
        }

        private void SetFalseMining(Collider obj)
        {
            if (obj.TryGetComponent(out PlayerInstaller playerInstaller))
                playerInstaller.CurrentEntity.GetBehaviour<PlayerStateBehaviour>().SetMiningFalse();
        }
    }
}