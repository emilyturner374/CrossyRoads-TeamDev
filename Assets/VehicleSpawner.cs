using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject vehicle;
    [SerializeField] private Transform spawnPos;
    [SerializeField] private int minWaitTime;
    [SerializeField] private int maxWaitTime;

    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(SpawnVehicles());
    }

    private IEnumerator SpawnVehicles() 
    {
        //Time in between spawns
        yield return new WaitForSeconds(Random.Range(minWaitTime, maxWaitTime));
        Instantiate(vehicle, spawnPos.position, Quaternion.identity);

    }
}
