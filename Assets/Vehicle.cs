using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    [SerializeField] private float speed;
    private float despawnTimer = 20f;

    private void Start()
    {
        Destroy(gameObject, despawnTimer);
    }

    // Update is called once per frame
    private void Update()
    {
        //Moves object forward along the z axis
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        
    }
}
