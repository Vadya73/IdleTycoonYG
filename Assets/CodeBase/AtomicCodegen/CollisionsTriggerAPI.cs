/**
* Code generation. Don't modify! 
**/

using UnityEngine;
using Atomic.Entities;
using System.Runtime.CompilerServices;
using Atomic.Elements;
using UnityEngine.InputSystem;
using CodeBase.Inventory;

namespace Atomic.Entities
{
    public static class CollisionsTriggerAPI
    {
        ///Keys
        public const int OnCollisionEnterAction = 16; // BaseEvent<Collision>
        public const int OnCollisionStayAction = 17; // BaseEvent<Collision>
        public const int OnCollisionExitAction = 18; // BaseEvent<Collision>


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static BaseEvent<Collision> GetOnCollisionEnterAction(this IEntity obj) => obj.GetValue<BaseEvent<Collision>>(OnCollisionEnterAction);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetOnCollisionEnterAction(this IEntity obj, out BaseEvent<Collision> value) => obj.TryGetValue(OnCollisionEnterAction, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddOnCollisionEnterAction(this IEntity obj, BaseEvent<Collision> value) => obj.AddValue(OnCollisionEnterAction, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasOnCollisionEnterAction(this IEntity obj) => obj.HasValue(OnCollisionEnterAction);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelOnCollisionEnterAction(this IEntity obj) => obj.DelValue(OnCollisionEnterAction);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetOnCollisionEnterAction(this IEntity obj, BaseEvent<Collision> value) => obj.SetValue(OnCollisionEnterAction, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static BaseEvent<Collision> GetOnCollisionStayAction(this IEntity obj) => obj.GetValue<BaseEvent<Collision>>(OnCollisionStayAction);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetOnCollisionStayAction(this IEntity obj, out BaseEvent<Collision> value) => obj.TryGetValue(OnCollisionStayAction, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddOnCollisionStayAction(this IEntity obj, BaseEvent<Collision> value) => obj.AddValue(OnCollisionStayAction, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasOnCollisionStayAction(this IEntity obj) => obj.HasValue(OnCollisionStayAction);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelOnCollisionStayAction(this IEntity obj) => obj.DelValue(OnCollisionStayAction);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetOnCollisionStayAction(this IEntity obj, BaseEvent<Collision> value) => obj.SetValue(OnCollisionStayAction, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static BaseEvent<Collision> GetOnCollisionExitAction(this IEntity obj) => obj.GetValue<BaseEvent<Collision>>(OnCollisionExitAction);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetOnCollisionExitAction(this IEntity obj, out BaseEvent<Collision> value) => obj.TryGetValue(OnCollisionExitAction, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddOnCollisionExitAction(this IEntity obj, BaseEvent<Collision> value) => obj.AddValue(OnCollisionExitAction, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasOnCollisionExitAction(this IEntity obj) => obj.HasValue(OnCollisionExitAction);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelOnCollisionExitAction(this IEntity obj) => obj.DelValue(OnCollisionExitAction);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetOnCollisionExitAction(this IEntity obj, BaseEvent<Collision> value) => obj.SetValue(OnCollisionExitAction, value);
    }
}
