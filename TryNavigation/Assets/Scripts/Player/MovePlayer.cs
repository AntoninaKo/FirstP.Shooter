using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {

    public float movementspeed = 6.0f;
    private CharacterController controller;


    void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            controller.Move(gameObject.transform.TransformDirection(Vector3.left) * Time.deltaTime * movementspeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            controller.Move(gameObject.transform.TransformDirection(Vector3.right) * Time.deltaTime * movementspeed);
        }
        if (Input.GetKey(KeyCode.W))
        {
            controller.Move(gameObject.transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementspeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //transform.Translate(Vector3.back * movementspeed * Time.deltaTime);
            controller.Move(gameObject.transform.TransformDirection(Vector3.back) * Time.deltaTime * movementspeed);
            //cl.transform.Translate(Vector3.back * movementspeed * Time.deltaTime);
            //controller.Move(Vector3.back * Time.deltaTime * movementspeed);
        }
    }
}
