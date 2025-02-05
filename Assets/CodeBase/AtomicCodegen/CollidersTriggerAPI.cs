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

namespace Atomic.Entities
{
    public static class CollidersTriggerAPI
    {
        ///Keys
        public const int OnTriggerEnterAction = 13; // BaseEvent<Collider>
        public const int OnTriggerStayAction = 14; // BaseEvent<Collider>
        public const int OnTriggerExitAction = 15; // BaseEvent<Collider>


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static BaseEvent<Collider> GetOnTriggerEnterAction(this IEntity obj) => obj.GetValue<BaseEvent<Collider>>(OnTriggerEnterAction);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetOnTriggerEnterAction(this IEntity obj, out BaseEvent<Collider> value) => obj.TryGetValue(OnTriggerEnterAction, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddOnTriggerEnterAction(this IEntity obj, BaseEvent<Collider> value) => obj.AddValue(OnTriggerEnterAction, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasOnTriggerEnterAction(this IEntity obj) => obj.HasValue(OnTriggerEnterAction);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelOnTriggerEnterAction(this IEntity obj) => obj.DelValue(OnTriggerEnterAction);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetOnTriggerEnterAction(this IEntity obj, BaseEvent<Collider> value) => obj.SetValue(OnTriggerEnterAction, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static BaseEvent<Collider> GetOnTriggerStayAction(this IEntity obj) => obj.GetValue<BaseEvent<Collider>>(OnTriggerStayAction);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetOnTriggerStayAction(this IEntity obj, out BaseEvent<Collider> value) => obj.TryGetValue(OnTriggerStayAction, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddOnTriggerStayAction(this IEntity obj, BaseEvent<Collider> value) => obj.AddValue(OnTriggerStayAction, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasOnTriggerStayAction(this IEntity obj) => obj.HasValue(OnTriggerStayAction);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelOnTriggerStayAction(this IEntity obj) => obj.DelValue(OnTriggerStayAction);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetOnTriggerStayAction(this IEntity obj, BaseEvent<Collider> value) => obj.SetValue(OnTriggerStayAction, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static BaseEvent<Collider> GetOnTriggerExitAction(this IEntity obj) => obj.GetValue<BaseEvent<Collider>>(OnTriggerExitAction);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetOnTriggerExitAction(this IEntity obj, out BaseEvent<Collider> value) => obj.TryGetValue(OnTriggerExitAction, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddOnTriggerExitAction(this IEntity obj, BaseEvent<Collider> value) => obj.AddValue(OnTriggerExitAction, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasOnTriggerExitAction(this IEntity obj) => obj.HasValue(OnTriggerExitAction);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelOnTriggerExitAction(this IEntity obj) => obj.DelValue(OnTriggerExitAction);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetOnTriggerExitAction(this IEntity obj, BaseEvent<Collider> value) => obj.SetValue(OnTriggerExitAction, value);
    }
}
