using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private GameObject prefab;

    private Queue<GameObject> pool;

    void Awake()
    {
        pool = new Queue<GameObject>();
        GrowPool();
    }

    public GameObject GetFromPool()
    {
        if (pool.Count <= 0)
        {
            GrowPool();
        }

        var nextObject = pool.Dequeue();
        nextObject.SetActive(true);
        return nextObject;
    }

    public void ReturnToPool(GameObject obj)
    {
        obj.SetActive(false);
        pool.Enqueue(obj);
    }

    private void GrowPool()
    {
        for (int i = 0; i < 10; i++)
        {
            var newObject = Instantiate(prefab);
            newObject.SetActive(false);
            pool.Enqueue(newObject);
        }
    }
}
