/*
 * Liam Barrett
 * Spring Assignment 2
 * PlayerController.cs
 * Script that allows player to control their character
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 10;
    public float jumpForce = 200;
    public Rigidbody2D rb;
    private Shoe speedShoe;
    private Shoe jumpShoe;
    public Text shoeText;

    void Start()
    {
        speedShoe = gameObject.GetComponent<SpeedShoe>();
        jumpShoe = gameObject.GetComponent<JumpShoe>();
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");

        Vector3 tempVect = new Vector3(h, 0, 0);
        tempVect = tempVect.normalized * speed * Time.deltaTime;

        gameObject.transform.position += tempVect;

        if (Input.GetKeyDown("space"))
        {
            if (gameObject.transform.position.y <= 0)
            {
                rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            }
        }

        if (Input.GetKeyDown("1"))
        {
            if (jumpShoe.isActiveShoe)
            {
                jumpShoe.endBuff();
            }

            speedShoe.setBuffBehavior();
            shoeText.text = "Current shoe: Speed Shoe";
            Debug.Log("Wearing Speed shoe");
        }

        if (Input.GetKeyDown("2"))
        {
            if (speedShoe.isActiveShoe)
            {
                speedShoe.endBuff();
            }

            jumpShoe.setBuffBehavior();
            shoeText.text = "Current shoe: Jump Shoe";
            Debug.Log("Wearing Jump shoe");
        }
    }
}
