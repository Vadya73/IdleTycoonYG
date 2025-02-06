using Atomic.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace CodeBase.Behaviours
{
    public sealed class BuildBehaviour : IEntityInit
    {
        private GameObject _prefabBuilding;
        private Transform _buildTransform;
        private DestroyGameObjectBehaviour _destroyGameObjectBehaviour;
        
        public void Init(IEntity entity)
        {
            _prefabBuilding = entity.GetBuildingPrefab();
            _buildTransform = entity.GetBuildingTransform();
            _destroyGameObjectBehaviour = entity.GetBehaviour<DestroyGameObjectBehaviour>();
        }

        public void Build()
        {
            Object.Instantiate(_prefabBuilding, _buildTransform.position, quaternion.identity);
            _destroyGameObjectBehaviour.DestroyObject();
        }
    }
}