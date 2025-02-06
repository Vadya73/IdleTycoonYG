/**
* Code generation. Don't modify! 
**/

using UnityEngine;
using Atomic.Entities;
using System.Runtime.CompilerServices;
using Atomic.Elements;
using UnityEngine.InputSystem;
using CodeBase.Inventory;
using CodeBase;
using UnityEngine.UI;
using TMPro;

namespace Atomic.Entities
{
    public static class InputAPI
    {
        ///Keys
        public const int OnMoveAction = 7; // BaseEvent<Vector2>
        public const int InputConfig = 8; // InputActionAsset


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static BaseEvent<Vector2> GetOnMoveAction(this IEntity obj) => obj.GetValue<BaseEvent<Vector2>>(OnMoveAction);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetOnMoveAction(this IEntity obj, out BaseEvent<Vector2> value) => obj.TryGetValue(OnMoveAction, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddOnMoveAction(this IEntity obj, BaseEvent<Vector2> value) => obj.AddValue(OnMoveAction, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasOnMoveAction(this IEntity obj) => obj.HasValue(OnMoveAction);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelOnMoveAction(this IEntity obj) => obj.DelValue(OnMoveAction);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetOnMoveAction(this IEntity obj, BaseEvent<Vector2> value) => obj.SetValue(OnMoveAction, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static InputActionAsset GetInputConfig(this IEntity obj) => obj.GetValue<InputActionAsset>(InputConfig);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetInputConfig(this IEntity obj, out InputActionAsset value) => obj.TryGetValue(InputConfig, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddInputConfig(this IEntity obj, InputActionAsset value) => obj.AddValue(InputConfig, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasInputConfig(this IEntity obj) => obj.HasValue(InputConfig);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelInputConfig(this IEntity obj) => obj.DelValue(InputConfig);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetInputConfig(this IEntity obj, InputActionAsset value) => obj.SetValue(InputConfig, value);
    }
}
