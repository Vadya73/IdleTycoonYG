using Atomic.Entities;
using UnityEngine;

namespace CodeBase.Behaviours
{
    public class DestroyGameObjectBehaviour : IEntityInit
    {
        [SerializeField] private GameObject _destroyObject;
        
        public void Init(IEntity entity)
        {
            _destroyObject = entity.GetDestroyObject();
        }

        public void DestroyObject()
        {
            Object.Destroy(_destroyObject);
        }
    }
}