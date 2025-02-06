using Atomic.Elements;
using Atomic.Entities;

namespace CodeBase.Behaviours.Observers
{
    public sealed class BuildObserverBehaviour : IEntityInit, IEntityDispose
    {
        private BaseEvent OnPurchaseEvent;
        private BuildBehaviour _buildBehaviour;
        public void Init(IEntity entity)
        {
            OnPurchaseEvent = entity.GetOnPurchaseEvent();
            
            _buildBehaviour = entity.GetBehaviour<BuildBehaviour>();

            OnPurchaseEvent.Subscribe(_buildBehaviour.Build);
        }
        
        public void Dispose(IEntity entity)
        {
            OnPurchaseEvent.Unsubscribe(_buildBehaviour.Build);
        }
    }
}