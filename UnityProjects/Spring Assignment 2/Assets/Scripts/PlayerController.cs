﻿/*
 * Liam Barrett
 * PlayerController.cs
 * Spring Assignment 2
 * Allows player to control the player character
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 tempVect = new Vector3(h, v, 0);
        tempVect = tempVect.normalized * speed * Time.deltaTime;

        transform.position += tempVect;
    }
}
