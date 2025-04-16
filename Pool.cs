using System.Collections.Generic;
using System;
using UnityEngine;

public class Pool
{
    private readonly List<GameObject> objects = new();

    public virtual GameObject Get()
    {
        var obj = SelectObject();
        objects.Remove(obj);
        obj.SetActive(true);
        return obj;
    }

    public virtual void Add(GameObject obj)
    {
        obj.SetActive(false);
        objects.Add(obj);
    }

    protected virtual GameObject SelectObject()
    {
        if (!HasObjects()) throw new Exception("No objects");
        return objects[0];
    }

    protected bool HasObjects()
    {
        return objects.Count > 0;
    }
}
