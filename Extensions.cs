using System;
using System.Collections.Generic;
using UnityEngine;

public static class Extensions
{
    /// <summary>
    /// Removes and returns the element at the specified index. Defaults to the last item.
    /// Supports negative indexing (e.g., -1 for last, -2 for second last).
    /// </summary>
    public static T Pop<T>(this List<T> list, int index = -1)
    {
        if (index < 0) index = list.Count + index;

        if (index < 0 || index >= list.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index out of range.");
        }

        T value = list[index];
        list.RemoveAt(index);
        return value;
    }

    public static Vector3 CalcLocalPosition(this Transform transform, Vector3 worldPosition)
    {
        if (transform.parent) return transform.parent.InverseTransformPoint(worldPosition);
        return worldPosition;
    }

    public static Vector2Int Abs(this Vector2Int vector)
    {
        return new Vector2Int(Mathf.Abs(vector.x), Mathf.Abs(vector.y));
    }
}
