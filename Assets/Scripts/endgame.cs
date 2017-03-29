using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class endgame : MonoBehaviour {
    
		void OnTriggerEnter(Collider other)
        {
           if (other.tag == "Player")
        {
            SceneManager.LoadScene("level2");
        }
       }
	
}
