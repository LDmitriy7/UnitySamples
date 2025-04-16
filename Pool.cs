using System.Collections.Generic;
using System;
using UnityEngine;

public class Pool
{
    private readonly List<GameObject> objects = new();

    public GameObject Get()
    {
        var obj = SelectObject();
        objects.Remove(obj);
        obj.SetActive(true);
        return obj;
    }

    public void Add(GameObject obj)
    {
        obj.SetActive(false);
        objects.Add(obj);
    }

    private GameObject SelectObject()
    {
        if (objects.Count == 0) throw new Exception("No objects");
        return objects[0];
    }
}
