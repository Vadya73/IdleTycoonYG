using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace CodeBase
{
    public class ResourceObjectInstaller : SceneEntityInstallerBase
    {
        [SerializeField] private ResourceType _resourceType;
        [SerializeField] private ReactiveVariable<int> _resourceCapacity;
            
        public override void Install(IEntity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}