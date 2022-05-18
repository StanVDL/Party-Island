using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public GameObject prefab;

    private Queue<GameObject> pool;

    void Awake()
    {
        pool = new Queue<GameObject>();
        GrowPool();
    }

    //Functie om de tubes uit de pool te halen
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

    //Functie om de pool opnieuw te laden
    public void ReturnToPool(GameObject obj)
    {
        obj.SetActive(false);
        pool.Enqueue(obj);
    }

    //Functie om automatisch een nieuwe tube (obstakel) toe te voegen aan de spawn pool
    public void GrowPool()
    {
        for (int i = 0; i < 10; i++)
        {
            var newObject = Instantiate(prefab);
            newObject.SetActive(false);
            pool.Enqueue(newObject);
        }
    }
}
