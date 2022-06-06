using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update ()
    {
        
    }
    void FixedUpdate()
    {
        rb.AddForce(Vector3.forward*speed, ForceMode.Force);
    }
}
