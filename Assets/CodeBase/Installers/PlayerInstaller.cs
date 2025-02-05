using Atomic.Elements;
using Atomic.Entities;
using CodeBase.Behaviours;
using CodeBase.Behaviours.Observers;
using UnityEngine;
using UnityEngine.InputSystem;

namespace CodeBase.Installers
{
    public sealed class PlayerInstaller : SceneEntityInstallerBase
    {
        // Input
        [SerializeField] private InputActionAsset _inputConfig;
        // Move
        [SerializeField] private Transform _root;
        [SerializeField] private ReactiveVariable<float> _speed;
        // Rotate
        [SerializeField] private Transform _rotateRoot;
        [SerializeField] private ReactiveVariable<float> _rotateSpeed;
        
        public override void Install(IEntity entity)
        {
            // Input
            entity.AddInputConfig(_inputConfig);
            // Move
            entity.AddRoot(_root);
            entity.AddMoveSpeed(_speed);
            entity.AddMoveDirection(new ReactiveVariable<Vector3>());
            // Rotate
            entity.AddRotateRoot(_rotateRoot);
            entity.AddRotateSpeed(_rotateSpeed);
            entity.AddRotateDirection(new ReactiveVariable<Vector3>());
            // Actions
            entity.AddOnMoveAction(new BaseEvent<Vector2>());
            // Systems
            entity.AddBehaviour(new InputReaderBehaviour());
            entity.AddBehaviour(new MovementBehaviour());
            entity.AddBehaviour(new RotateBehaviour());
            entity.AddBehaviour(new PlayerObserveBehaviour());
        }
    }
}