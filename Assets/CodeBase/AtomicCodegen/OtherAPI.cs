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
    public static class OtherAPI
    {
        ///Keys
        public const int DestroyObject = 24; // GameObject
        public const int SecondsForWaiting = 25; // ReactiveVariable<int>
        public const int OnProgressStart = 31; // BaseEvent
        public const int OnProgressCancel = 32; // BaseEvent


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static GameObject GetDestroyObject(this IEntity obj) => obj.GetValue<GameObject>(DestroyObject);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetDestroyObject(this IEntity obj, out GameObject value) => obj.TryGetValue(DestroyObject, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddDestroyObject(this IEntity obj, GameObject value) => obj.AddValue(DestroyObject, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasDestroyObject(this IEntity obj) => obj.HasValue(DestroyObject);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelDestroyObject(this IEntity obj) => obj.DelValue(DestroyObject);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetDestroyObject(this IEntity obj, GameObject value) => obj.SetValue(DestroyObject, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVariable<int> GetSecondsForWaiting(this IEntity obj) => obj.GetValue<ReactiveVariable<int>>(SecondsForWaiting);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetSecondsForWaiting(this IEntity obj, out ReactiveVariable<int> value) => obj.TryGetValue(SecondsForWaiting, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddSecondsForWaiting(this IEntity obj, ReactiveVariable<int> value) => obj.AddValue(SecondsForWaiting, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasSecondsForWaiting(this IEntity obj) => obj.HasValue(SecondsForWaiting);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelSecondsForWaiting(this IEntity obj) => obj.DelValue(SecondsForWaiting);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetSecondsForWaiting(this IEntity obj, ReactiveVariable<int> value) => obj.SetValue(SecondsForWaiting, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static BaseEvent GetOnProgressStart(this IEntity obj) => obj.GetValue<BaseEvent>(OnProgressStart);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetOnProgressStart(this IEntity obj, out BaseEvent value) => obj.TryGetValue(OnProgressStart, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddOnProgressStart(this IEntity obj, BaseEvent value) => obj.AddValue(OnProgressStart, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasOnProgressStart(this IEntity obj) => obj.HasValue(OnProgressStart);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelOnProgressStart(this IEntity obj) => obj.DelValue(OnProgressStart);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetOnProgressStart(this IEntity obj, BaseEvent value) => obj.SetValue(OnProgressStart, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static BaseEvent GetOnProgressCancel(this IEntity obj) => obj.GetValue<BaseEvent>(OnProgressCancel);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetOnProgressCancel(this IEntity obj, out BaseEvent value) => obj.TryGetValue(OnProgressCancel, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddOnProgressCancel(this IEntity obj, BaseEvent value) => obj.AddValue(OnProgressCancel, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasOnProgressCancel(this IEntity obj) => obj.HasValue(OnProgressCancel);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelOnProgressCancel(this IEntity obj) => obj.DelValue(OnProgressCancel);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetOnProgressCancel(this IEntity obj, BaseEvent value) => obj.SetValue(OnProgressCancel, value);
    }
}
