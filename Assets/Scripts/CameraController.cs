using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform target;
    private Vector3 followoffset;

    private void Start()
    {
        followoffset = transform.position - target.position;
    }
    private void Update ()
    {
        transform.position = target.position + followoffset;
	}
}
