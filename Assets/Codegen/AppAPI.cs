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
		public const int Wallet = 1; // WalletInstaller


		///Extensions
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static WalletInstaller GetWallet(this IContext obj) => obj.ResolveValue<WalletInstaller>(Wallet);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetWallet(this IContext obj, out WalletInstaller value) => obj.TryResolveValue(Wallet, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddWallet(this IContext obj, WalletInstaller value) => obj.AddValue(Wallet, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelWallet(this IContext obj) => obj.DelValue(Wallet);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetWallet(this IContext obj, WalletInstaller value) => obj.SetValue(Wallet, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasWallet(this IContext obj) => obj.HasValue(Wallet);
    }
}
