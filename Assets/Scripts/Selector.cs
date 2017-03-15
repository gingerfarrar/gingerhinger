using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : MonoBehaviour
{
    public GameObject[] targets;

    private int activeIdx;

    private void Select(int selectedIdx)
    {
        for(int i = 0; i < targets.Length; ++i)
        {
            targets[i].SetActive(false);
        }

        targets[selectedIdx].SetActive(true);

    }
    
    private void Start()
    {
     
        activeIdx = Random.Range(0, targets.Length - 1);

        Select(activeIdx);
    }

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.D))
        {
            activeIdx = (activeIdx + 1) % targets.Length;
            Select(activeIdx);
        }
    }
}
