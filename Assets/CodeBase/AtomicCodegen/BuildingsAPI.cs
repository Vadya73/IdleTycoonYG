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
    public static class BuildingsAPI
    {
        ///Keys
        public const int BuildPrefab = 25; // GameObject
        public const int Cost = 26; // ReactiveVariable<int>


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static GameObject GetBuildPrefab(this IEntity obj) => obj.GetValue<GameObject>(BuildPrefab);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetBuildPrefab(this IEntity obj, out GameObject value) => obj.TryGetValue(BuildPrefab, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddBuildPrefab(this IEntity obj, GameObject value) => obj.AddValue(BuildPrefab, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasBuildPrefab(this IEntity obj) => obj.HasValue(BuildPrefab);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelBuildPrefab(this IEntity obj) => obj.DelValue(BuildPrefab);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetBuildPrefab(this IEntity obj, GameObject value) => obj.SetValue(BuildPrefab, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVariable<int> GetCost(this IEntity obj) => obj.GetValue<ReactiveVariable<int>>(Cost);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetCost(this IEntity obj, out ReactiveVariable<int> value) => obj.TryGetValue(Cost, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddCost(this IEntity obj, ReactiveVariable<int> value) => obj.AddValue(Cost, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasCost(this IEntity obj) => obj.HasValue(Cost);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelCost(this IEntity obj) => obj.DelValue(Cost);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetCost(this IEntity obj, ReactiveVariable<int> value) => obj.SetValue(Cost, value);
    }
}
