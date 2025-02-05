using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace CodeBase.Installers
{
    [RequireComponent(typeof(Collider))]
    public sealed class ColliderTriggersHandleInstaller : SceneEntityInstallerBase
    {
        private BaseEvent<Collider> OnTriggerEnterAction = new();
        private BaseEvent<Collider> OnTriggerStayAction = new();
        private BaseEvent<Collider> OnTriggerExitAction = new();
        
        public override void Install(IEntity entity)
        {
            entity.AddOnTriggerEnterAction(OnTriggerEnterAction);
            entity.AddOnTriggerStayAction(OnTriggerStayAction);
            entity.AddOnTriggerExitAction(OnTriggerExitAction);
        }

        private void OnTriggerEnter(Collider other) => OnTriggerEnterAction.Invoke(other);

        private void OnTriggerStay(Collider other) => OnTriggerStayAction.Invoke(other);

        private void OnTriggerExit(Collider other) => OnTriggerExitAction.Invoke(other);
    }
}