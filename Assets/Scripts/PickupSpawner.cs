using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawner : MonoBehaviour
{

    public int numbertospawn = 0;
    public GameObject SpawnPrefab;

    public float radius = 5;

    private void Start()
    {
        for(int i = 0; i < numbertospawn; ++i)
        {
            float randX = Random.Range(-radius, radius);
            float randZ = Random.Range(-radius, radius);

            GameObject babyPickup = Instantiate(SpawnPrefab);

            babyPickup.transform.position = transform.position + new Vector3(randX, 0, randZ);
        }
    }
}
