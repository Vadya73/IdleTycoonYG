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
    public static class UIAPI
    {
        ///Keys
        public const int ProgressBarImage = 30; // Image
        public const int ProgressText = 33; // TMP_Text


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Image GetProgressBarImage(this IEntity obj) => obj.GetValue<Image>(ProgressBarImage);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetProgressBarImage(this IEntity obj, out Image value) => obj.TryGetValue(ProgressBarImage, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddProgressBarImage(this IEntity obj, Image value) => obj.AddValue(ProgressBarImage, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasProgressBarImage(this IEntity obj) => obj.HasValue(ProgressBarImage);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelProgressBarImage(this IEntity obj) => obj.DelValue(ProgressBarImage);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetProgressBarImage(this IEntity obj, Image value) => obj.SetValue(ProgressBarImage, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TMP_Text GetProgressText(this IEntity obj) => obj.GetValue<TMP_Text>(ProgressText);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetProgressText(this IEntity obj, out TMP_Text value) => obj.TryGetValue(ProgressText, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddProgressText(this IEntity obj, TMP_Text value) => obj.AddValue(ProgressText, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasProgressText(this IEntity obj) => obj.HasValue(ProgressText);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelProgressText(this IEntity obj) => obj.DelValue(ProgressText);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetProgressText(this IEntity obj, TMP_Text value) => obj.SetValue(ProgressText, value);
    }
}
