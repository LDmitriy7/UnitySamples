using System;
using System.Collections.Generic;
using UnityEngine;

public static class Extensions
{
    public static T Pop<T>(this List<T> list)
    {
        if (list.Count == 0) throw new Exception("Cannot pop from an empty list.");
        T lastElement = list[^1];
        list.RemoveAt(list.Count - 1);
        return lastElement;
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
