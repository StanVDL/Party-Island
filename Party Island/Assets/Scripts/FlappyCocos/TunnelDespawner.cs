using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TunnelDespawner : MonoBehaviour
{
    [SerializeField] private ObjectPool pool;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Tube"))
        {
            pool.ReturnToPool(other.gameObject);
        }
    }
}
