using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;
using UnityEngine.InputSystem;

namespace CodeBase.Behaviours
{
    // TODO:  Сделать SO с массивом инпут экшенов и прокидывать его, а не конфиг
    public sealed class InputReaderBehaviour : IEntityInit, IEntityUpdate
    {
        private InputActionAsset _inputConfig;
        
        private InputAction _moveInputAction;
        private BaseEvent<Vector2> OnMoveAction;

        void IEntityInit.Init(IEntity entity)
        {
            _inputConfig = entity.GetInputConfig();
            OnMoveAction = entity.GetOnMoveAction();
            
            InitializeActions();
        }

        void IEntityUpdate.OnUpdate(IEntity entity, float deltaTime)
        {
            HandleMoveAction();
        }
        
        private void HandleMoveAction()
        {
            if (_moveInputAction.IsPressed())
                OnMoveAction.Invoke(_moveInputAction.ReadValue<Vector2>());
        }

        private void InitializeActions()
        {
            _moveInputAction = _inputConfig.FindAction("Move");
        }
    }
}
