using UnityEngine;

public class Spawner : Pool
{
    readonly GameObject prefab;
    readonly Transform transform;

    public Spawner(GameObject prefab, int count, Transform transform = null)
    {
        this.prefab = prefab;
        this.transform = transform;
        for (int i = 0; i < count; i++) Create();
    }

    public override GameObject Get()
    {
        if (!HasObjects()) return Instantiate();
        return base.Get();
    }

    private void Create()
    {
        var gameObject = Instantiate();
        Add(gameObject);
    }

    private GameObject Instantiate()
    {
        return Object.Instantiate(prefab, transform);
    }
}
