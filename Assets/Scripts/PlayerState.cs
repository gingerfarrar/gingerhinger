using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour
{
    public int Score;

    [SerializeField]
    private Inventory playerInventory;

    private void OnTriggerEnter(Collider other)
    {
        Pickup target = other.GetComponent<Pickup>();
        if(target != null)
        {
            Item temp = target.GetItem();
            playerInventory.AddItem(temp);
        }
    }
}
