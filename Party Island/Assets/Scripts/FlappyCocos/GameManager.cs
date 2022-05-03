using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    private static GameManager manager;
    public static GameManager Instance
    {
        get
        {
            if (manager == null)
            {
                manager = GameObject.FindObjectOfType<GameManager>();
                
                if (manager != null)
                {
                    var newObject = new GameObject();
                    manager = newObject.AddComponent<GameManager>();
                }
            }

            return manager;
        }
    }

    public UnityEvent OnPlayerDeath;

    private void Awake()
    {
        if (manager == null)
        {
            manager = this;
        }

        if (manager != this)
        {
            Destroy(this.gameObject);
        }

        OnPlayerDeath = new UnityEvent();
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
