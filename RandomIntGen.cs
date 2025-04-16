using System;
using Random = UnityEngine.Random;

[Serializable]
public class RandomIntGen : IntRange
{
    public int Gen()
    {
        return Random.Range(min, max + 1);
    }
}
