using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ObjectPool))]

public class Spawner : MonoBehaviour
{
    [SerializeField] private float spawnRate; //Time between spawns in seconds
    [SerializeField] private Vector2 gapRange;
    [SerializeField] private float gapSize;
    [SerializeField] private float xPos;
    [SerializeField] private float zPos;

    [SerializeField] private ObjectPool tunnelPool;
    [SerializeField] private ObjectPool scoreTriggerPool;

    void Start()
    {
        GameManager.Instance.OnPlayerDeath.AddListener(OnPlayerDeath);
        StartCoroutine(SpawnAsync());
    }

    private IEnumerator SpawnAsync()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnRate);

            //Spawn tubes
            var topTube = tunnelPool.GetFromPool();
            var bottomTube = tunnelPool.GetFromPool();

            var gapPosition = Random.Range(gapRange.x, gapRange.y);
            bottomTube.transform.position = new Vector3(xPos, gapPosition - gapSize - bottomTube.transform.localScale.y/2, zPos);
            topTube.transform.position = new Vector3(xPos, gapPosition + gapSize + topTube.transform.localScale.y/2, zPos);
        }
    }

    private void OnPlayerDeath()
    {
        StopAllCoroutines();
    }
}
