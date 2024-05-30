using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class FPSController : MonoBehaviour
{
    Rigidbody myRigidBody;


    CharacterController characterController;
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();

    }

    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.D))
        {
            myRigidBody.AddForce(new Vector3(10, 0, 0));
        }

        if (Input.GetKey(KeyCode.A))
        {
            myRigidBody.AddForce(new Vector3(-10, 0, 0));
        }

    }
}