using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogSpawner : MonoBehaviour
{
    [SerializeField] private GameObject log;
    [SerializeField] private Transform spawnPos;
    [SerializeField] private int minWaitTime;
    [SerializeField] private int maxWaitTime;

    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(SpawnLogs());
    }

    private IEnumerator SpawnLogs()
    {
        //Time in between spawns
        yield return new WaitForSeconds(Random.Range(minWaitTime, maxWaitTime));
        Instantiate(log, spawnPos.position, Quaternion.identity);
    }
}
