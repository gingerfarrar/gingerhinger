using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HUDcontroller : MonoBehaviour {

    public Text scoreText;
    public PlayerState playerscore;
	
	
	void Update ()
    {
        scoreText.text = playerscore.Score.ToString();
	}
}
