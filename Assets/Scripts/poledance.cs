using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poledance : MonoBehaviour
{

    public Transform target;
    public float minRotationSpeed = 80.0f;
    public float maxRotationSpeed = 120.0f;
    public float minMovementSpeed = 1.75f;
    public float maxMovementSpeed = 2.25f;
    private float rotationSpeed = 75.0f; 
    private float movementSpeed = 2.0f;
    private Quaternion qTo;

    void Start()
    {
        target = GameObject.Find("chan").transform;
        rotationSpeed = Random.Range(minRotationSpeed, maxRotationSpeed);
        movementSpeed = Random.Range(minMovementSpeed, maxMovementSpeed);
    }

    // Update is called once per frame
    void Update ()
    {
        Vector3 v3 = target.position - transform.position;
        float angle = Mathf.Atan2(v3.y, v3.x) * Mathf.Rad2Deg;
        qTo = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, qTo, rotationSpeed * Time.deltaTime);
        transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
    }
}
