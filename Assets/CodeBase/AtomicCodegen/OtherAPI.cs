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
    public static class OtherAPI
    {
        ///Keys
        public const int DestroyObject = 24; // GameObject


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
    }
}
