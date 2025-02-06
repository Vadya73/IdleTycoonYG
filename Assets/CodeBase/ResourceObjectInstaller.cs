using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace CodeBase
{
    public class ResourceObjectInstaller : SceneEntityInstallerBase
    {
        public Transform CurrentTransform => _currentTransform;
        
        [SerializeField] private ResourceType _resourceType;
        [SerializeField] private ReactiveVariable<int> _resourceCapacity;
        [SerializeField] private Transform _currentTransform;


        public override void Install(IEntity entity)
        {
            _currentTransform = this.gameObject.transform;
                
            entity.AddOnTriggerEnterAction(new BaseEvent<Collider>());
            entity.AddOnTriggerExitAction(new BaseEvent<Collider>());
            entity.AddCurrentTransform(_currentTransform);

            entity.AddBehaviour(new ResourceObjectObserveBehaviour());
        }
    }
}