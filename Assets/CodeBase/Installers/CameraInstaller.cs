using Atomic.Elements;
using Atomic.Entities;
using CodeBase.Behaviours;
using UnityEngine;

namespace CodeBase.Installers
{
    public sealed class CameraInstaller : SceneEntityInstallerBase
    {
        [SerializeField] private Transform _cameraTransform;
        [SerializeField] private Transform _followTarget;
        [SerializeField] private ReactiveVariable<Vector3> _followOffset;
        [SerializeField] private ReactiveVariable<float> _speed;

        public override void Install(IEntity entity)
        {
            entity.AddCurrentTransform(_cameraTransform);
            entity.AddFollowTarget(_followTarget);
            entity.AddFollowOffset(_followOffset);
            entity.AddFollowSpeed(_speed);

            entity.AddBehaviour(new FollowBehaviour());
        }
    }
}