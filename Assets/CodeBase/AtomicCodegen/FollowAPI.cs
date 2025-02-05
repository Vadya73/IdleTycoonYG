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
    public static class FollowAPI
    {
        ///Keys
        public const int FollowTarget = 9; // Transform
        public const int FollowOffset = 10; // ReactiveVariable<Vector3>
        public const int FollowSpeed = 11; // ReactiveVariable<float>
        public const int CurrentTransform = 12; // Transform


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Transform GetFollowTarget(this IEntity obj) => obj.GetValue<Transform>(FollowTarget);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetFollowTarget(this IEntity obj, out Transform value) => obj.TryGetValue(FollowTarget, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddFollowTarget(this IEntity obj, Transform value) => obj.AddValue(FollowTarget, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasFollowTarget(this IEntity obj) => obj.HasValue(FollowTarget);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelFollowTarget(this IEntity obj) => obj.DelValue(FollowTarget);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetFollowTarget(this IEntity obj, Transform value) => obj.SetValue(FollowTarget, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVariable<Vector3> GetFollowOffset(this IEntity obj) => obj.GetValue<ReactiveVariable<Vector3>>(FollowOffset);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetFollowOffset(this IEntity obj, out ReactiveVariable<Vector3> value) => obj.TryGetValue(FollowOffset, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddFollowOffset(this IEntity obj, ReactiveVariable<Vector3> value) => obj.AddValue(FollowOffset, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasFollowOffset(this IEntity obj) => obj.HasValue(FollowOffset);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelFollowOffset(this IEntity obj) => obj.DelValue(FollowOffset);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetFollowOffset(this IEntity obj, ReactiveVariable<Vector3> value) => obj.SetValue(FollowOffset, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVariable<float> GetFollowSpeed(this IEntity obj) => obj.GetValue<ReactiveVariable<float>>(FollowSpeed);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetFollowSpeed(this IEntity obj, out ReactiveVariable<float> value) => obj.TryGetValue(FollowSpeed, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddFollowSpeed(this IEntity obj, ReactiveVariable<float> value) => obj.AddValue(FollowSpeed, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasFollowSpeed(this IEntity obj) => obj.HasValue(FollowSpeed);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelFollowSpeed(this IEntity obj) => obj.DelValue(FollowSpeed);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetFollowSpeed(this IEntity obj, ReactiveVariable<float> value) => obj.SetValue(FollowSpeed, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Transform GetCurrentTransform(this IEntity obj) => obj.GetValue<Transform>(CurrentTransform);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetCurrentTransform(this IEntity obj, out Transform value) => obj.TryGetValue(CurrentTransform, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddCurrentTransform(this IEntity obj, Transform value) => obj.AddValue(CurrentTransform, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasCurrentTransform(this IEntity obj) => obj.HasValue(CurrentTransform);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelCurrentTransform(this IEntity obj) => obj.DelValue(CurrentTransform);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetCurrentTransform(this IEntity obj, Transform value) => obj.SetValue(CurrentTransform, value);
    }
}
