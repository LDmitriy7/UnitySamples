using System;
using Random = UnityEngine.Random;

[Serializable]
public class RandomIntGen
{
    public int minValue = 0;
    public int maxValue = 1;
    
    public int Gen()
    {
        return Random.Range(minValue, maxValue + 1);
    }
}
