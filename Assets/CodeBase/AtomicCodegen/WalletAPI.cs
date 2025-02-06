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
    public static class WalletAPI
    {
        ///Keys
        public const int Coins = 19; // ReactiveVariable<int>
        public const int Diamonds = 20; // ReactiveVariable<int>
        public const int Worth = 22; // ReactiveVariable<int>
        public const int WalletType = 23; // WalletType


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVariable<int> GetCoins(this IEntity obj) => obj.GetValue<ReactiveVariable<int>>(Coins);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetCoins(this IEntity obj, out ReactiveVariable<int> value) => obj.TryGetValue(Coins, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddCoins(this IEntity obj, ReactiveVariable<int> value) => obj.AddValue(Coins, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasCoins(this IEntity obj) => obj.HasValue(Coins);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelCoins(this IEntity obj) => obj.DelValue(Coins);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetCoins(this IEntity obj, ReactiveVariable<int> value) => obj.SetValue(Coins, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVariable<int> GetDiamonds(this IEntity obj) => obj.GetValue<ReactiveVariable<int>>(Diamonds);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetDiamonds(this IEntity obj, out ReactiveVariable<int> value) => obj.TryGetValue(Diamonds, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddDiamonds(this IEntity obj, ReactiveVariable<int> value) => obj.AddValue(Diamonds, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasDiamonds(this IEntity obj) => obj.HasValue(Diamonds);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelDiamonds(this IEntity obj) => obj.DelValue(Diamonds);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetDiamonds(this IEntity obj, ReactiveVariable<int> value) => obj.SetValue(Diamonds, value);

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
        public static WalletType GetWalletType(this IEntity obj) => obj.GetValue<WalletType>(WalletType);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetWalletType(this IEntity obj, out WalletType value) => obj.TryGetValue(WalletType, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddWalletType(this IEntity obj, WalletType value) => obj.AddValue(WalletType, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasWalletType(this IEntity obj) => obj.HasValue(WalletType);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelWalletType(this IEntity obj) => obj.DelValue(WalletType);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetWalletType(this IEntity obj, WalletType value) => obj.SetValue(WalletType, value);
    }
}
