using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public int Value = 1;
    public Sprite inventoryImage;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerState state = other.GetComponent<PlayerState>();
            state.Score += Value;
            Destroy(gameObject);
        }
    }

    public Item GetItem()
    {
        Item temp = new Item();

        temp.sprite = inventoryImage;

        return temp;
    }
    
}
