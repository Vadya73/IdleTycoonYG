/**
* Code generation. Don't modify! 
**/

using UnityEngine;
using Atomic.Contexts;
using System.Runtime.CompilerServices;
using CodeBase;

namespace Atomic.Contexts
{
	public static class AppAPI
	{
		///Keys
		public const int Wallet = 1; // Wallet


		///Extensions
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Wallet GetWallet(this IContext obj) => obj.ResolveValue<Wallet>(Wallet);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetWallet(this IContext obj, out Wallet value) => obj.TryResolveValue(Wallet, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddWallet(this IContext obj, Wallet value) => obj.AddValue(Wallet, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelWallet(this IContext obj) => obj.DelValue(Wallet);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetWallet(this IContext obj, Wallet value) => obj.SetValue(Wallet, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasWallet(this IContext obj) => obj.HasValue(Wallet);
    }
}
