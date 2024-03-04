using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private float speed = 20;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //move the vehicle foward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput); 
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime); }
    }

