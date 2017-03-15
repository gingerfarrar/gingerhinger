using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public int Value = 1;


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerState state = other.GetComponent<PlayerState>();
            state.Score += Value;
            Destroy(gameObject);
        }
    }
}
