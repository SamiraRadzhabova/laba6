using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private const float speed = 20f;
    [SerializeField] private float turnSpeed = 45f;
    private float horizontalInput;
    private float verticalInput;

    void Start()
    {
        //speed = 10;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //This is where we get player input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        //We move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        //We move the vehicle 
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
