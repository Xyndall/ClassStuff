﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.8f;

    Vector3 velocity;
    



    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        gameObject.transform.position += move * Time.deltaTime;

        

        //controller.Move(move * speed * Time.deltaTime);

        //controller.Move(velocity * Time.deltaTime);
    }
}
