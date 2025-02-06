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
    public static class BuildingsAPI
    {
        ///Keys
        public const int Cost = 26; // ReactiveVariable<int>
        public const int BuildingPrefab = 27; // GameObject
        public const int BuildingTransform = 28; // Transform
        public const int OnPurchaseEvent = 29; // BaseEvent


        ///Extensions
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static GameObject GetBuildingPrefab(this IEntity obj) => obj.GetValue<GameObject>(BuildingPrefab);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetBuildingPrefab(this IEntity obj, out GameObject value) => obj.TryGetValue(BuildingPrefab, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddBuildingPrefab(this IEntity obj, GameObject value) => obj.AddValue(BuildingPrefab, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasBuildingPrefab(this IEntity obj) => obj.HasValue(BuildingPrefab);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelBuildingPrefab(this IEntity obj) => obj.DelValue(BuildingPrefab);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetBuildingPrefab(this IEntity obj, GameObject value) => obj.SetValue(BuildingPrefab, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Transform GetBuildingTransform(this IEntity obj) => obj.GetValue<Transform>(BuildingTransform);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetBuildingTransform(this IEntity obj, out Transform value) => obj.TryGetValue(BuildingTransform, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddBuildingTransform(this IEntity obj, Transform value) => obj.AddValue(BuildingTransform, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasBuildingTransform(this IEntity obj) => obj.HasValue(BuildingTransform);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelBuildingTransform(this IEntity obj) => obj.DelValue(BuildingTransform);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetBuildingTransform(this IEntity obj, Transform value) => obj.SetValue(BuildingTransform, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static BaseEvent GetOnPurchaseEvent(this IEntity obj) => obj.GetValue<BaseEvent>(OnPurchaseEvent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetOnPurchaseEvent(this IEntity obj, out BaseEvent value) => obj.TryGetValue(OnPurchaseEvent, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddOnPurchaseEvent(this IEntity obj, BaseEvent value) => obj.AddValue(OnPurchaseEvent, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasOnPurchaseEvent(this IEntity obj) => obj.HasValue(OnPurchaseEvent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelOnPurchaseEvent(this IEntity obj) => obj.DelValue(OnPurchaseEvent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetOnPurchaseEvent(this IEntity obj, BaseEvent value) => obj.SetValue(OnPurchaseEvent, value);
    }
}
