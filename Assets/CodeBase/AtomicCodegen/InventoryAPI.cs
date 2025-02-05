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
    public static class InventoryAPI
    {
        ///Keys
        public const int Items = 21; // ReactiveList<Item>


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveList<Item> GetItems(this IEntity obj) => obj.GetValue<ReactiveList<Item>>(Items);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetItems(this IEntity obj, out ReactiveList<Item> value) => obj.TryGetValue(Items, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddItems(this IEntity obj, ReactiveList<Item> value) => obj.AddValue(Items, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasItems(this IEntity obj) => obj.HasValue(Items);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelItems(this IEntity obj) => obj.DelValue(Items);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetItems(this IEntity obj, ReactiveList<Item> value) => obj.SetValue(Items, value);
    }
}
