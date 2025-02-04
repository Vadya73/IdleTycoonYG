using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace CodeBase.Installers
{
    public sealed class ColliderCollisionsHandleInstaller : SceneEntityInstallerBase
    {
        private BaseEvent<Collision> OnCollisionEnterAction = new();
        private BaseEvent<Collision> OnCollisionStayAction = new();
        private BaseEvent<Collision> OnCollisionExitAction = new();
        public override void Install(IEntity entity)
        {
            entity.AddOnCollisionEnterAction(OnCollisionEnterAction);
            entity.AddOnCollisionStayAction(OnCollisionStayAction);
            entity.AddOnCollisionExitAction(OnCollisionExitAction);
        }

        private void OnCollisionEnter(Collision other)
        {
            OnCollisionEnterAction.Invoke(other);
        }

        private void OnCollisionStay(Collision other)
        {
            OnCollisionStayAction.Invoke(other);
        }

        private void OnCollisionExit(Collision other)
        {
            OnCollisionExitAction.Invoke(other);
        }
    }
}