using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class replay : MonoBehaviour
{
    public void LoadByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            LoadByIndex(1);
        }
        if(Input.GetKeyDown(KeyCode.Q))
        {
            UnityEditor.EditorApplication.isPlaying = false;
            Application.Quit();
        }
    }
    
	
}
