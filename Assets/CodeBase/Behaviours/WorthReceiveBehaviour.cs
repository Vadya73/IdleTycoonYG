using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace CodeBase.Behaviours
{
    public class WorthReceiveBehaviour : IEntityInit
    {
        private ReactiveVariable<int> _worth;
        public void Init(IEntity entity)
        {
            _worth = entity.GetWorth();
            
            var onTrigger = entity.GetOnTriggerEnterAction();

            onTrigger.Subscribe(Receive);
        }

        private void Receive(Collider obj)
        {
            
        }
    }
}