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
    public static class StatesAPI
    {
        ///Keys
        public const int CanMine = 34; // ReactiveVariable<bool>
        public const int IsMoving = 35; // ReactiveVariable<bool>


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVariable<bool> GetCanMine(this IEntity obj) => obj.GetValue<ReactiveVariable<bool>>(CanMine);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetCanMine(this IEntity obj, out ReactiveVariable<bool> value) => obj.TryGetValue(CanMine, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddCanMine(this IEntity obj, ReactiveVariable<bool> value) => obj.AddValue(CanMine, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasCanMine(this IEntity obj) => obj.HasValue(CanMine);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelCanMine(this IEntity obj) => obj.DelValue(CanMine);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetCanMine(this IEntity obj, ReactiveVariable<bool> value) => obj.SetValue(CanMine, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVariable<bool> GetIsMoving(this IEntity obj) => obj.GetValue<ReactiveVariable<bool>>(IsMoving);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetIsMoving(this IEntity obj, out ReactiveVariable<bool> value) => obj.TryGetValue(IsMoving, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddIsMoving(this IEntity obj, ReactiveVariable<bool> value) => obj.AddValue(IsMoving, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasIsMoving(this IEntity obj) => obj.HasValue(IsMoving);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelIsMoving(this IEntity obj) => obj.DelValue(IsMoving);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetIsMoving(this IEntity obj, ReactiveVariable<bool> value) => obj.SetValue(IsMoving, value);
    }
}
