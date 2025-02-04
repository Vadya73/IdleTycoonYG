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
    public static class WalletAPI
    {
        ///Keys
        public const int Worth = 19; // ReactiveVariable<int>
        public const int ReceiveItem = 20; // Item


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVariable<int> GetWorth(this IEntity obj) => obj.GetValue<ReactiveVariable<int>>(Worth);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetWorth(this IEntity obj, out ReactiveVariable<int> value) => obj.TryGetValue(Worth, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddWorth(this IEntity obj, ReactiveVariable<int> value) => obj.AddValue(Worth, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasWorth(this IEntity obj) => obj.HasValue(Worth);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelWorth(this IEntity obj) => obj.DelValue(Worth);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetWorth(this IEntity obj, ReactiveVariable<int> value) => obj.SetValue(Worth, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Item GetReceiveItem(this IEntity obj) => obj.GetValue<Item>(ReceiveItem);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetReceiveItem(this IEntity obj, out Item value) => obj.TryGetValue(ReceiveItem, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddReceiveItem(this IEntity obj, Item value) => obj.AddValue(ReceiveItem, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasReceiveItem(this IEntity obj) => obj.HasValue(ReceiveItem);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelReceiveItem(this IEntity obj) => obj.DelValue(ReceiveItem);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetReceiveItem(this IEntity obj, Item value) => obj.SetValue(ReceiveItem, value);
    }
}
