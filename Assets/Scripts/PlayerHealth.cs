using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerHealth : MonoBehaviour, IDamageable
{
    public float healthValue = 20.0f;
   
    public void TakeDamage(float damageDealt)
    {
        healthValue -= damageDealt;

        if(healthValue <= 0)
        {
            SceneManager.LoadScene("gameover");
        }
    }

   
}
