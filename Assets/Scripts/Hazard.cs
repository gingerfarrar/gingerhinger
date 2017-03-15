using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour {

    public float damageValue = 10.0f;

    private void OnCollisionEnter(Collision other)
    {
        IDamageable target = other.gameObject.GetComponent<IDamageable>();

        // exit early if this can't damage it
        if (target == null)
        {
            return;
        }

        target.TakeDamage(damageValue);
        Destroy(gameObject);
    }
}
