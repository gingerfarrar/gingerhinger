using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HUDcontroller : MonoBehaviour {

    public Text scoreText;
    public PlayerState playerscore;
    public Text healthText;
    public PlayerHealth playerhealth;

	void Update ()
    {
        scoreText.text = playerscore.Score.ToString();
        healthText.text = playerhealth.healthValue.ToString();
	}
}
