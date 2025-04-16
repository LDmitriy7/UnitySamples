using System.Collections.Generic;
using System;
using UnityEngine;

public static class DictJsonUtility
{
    [Serializable]
    private class DictData<K, V>
    {
        public List<K> keys = new();
        public List<V> values = new();
    }

    public static string ToJson<K, V>(Dictionary<K, V> dict)
    {
        var dictData = new DictData<K, V>();

        foreach (var kvp in dict)
        {
            dictData.keys.Add(kvp.Key);
            dictData.values.Add(kvp.Value);
        }

        return JsonUtility.ToJson(dictData);
    }

    public static Dictionary<K, V> FromJson<K, V>(string json)
    {
        var dictData = JsonUtility.FromJson<DictData<K, V>>(json);
        var dict = new Dictionary<K, V>();

        for (int i = 0; i < dictData.keys.Count; i++)
        {
            dict[dictData.keys[i]] = dictData.values[i];
        }

        return dict;
    }
}
