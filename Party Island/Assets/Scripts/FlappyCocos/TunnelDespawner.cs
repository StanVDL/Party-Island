using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TunnelDespawner : MonoBehaviour
{
    public ObjectPool pool;

    //Zorgt dat de tubes verdwijnen zodra ze uit beeld zijn
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Tube"))
        {
            pool.ReturnToPool(other.gameObject);
        }
    }
}
