using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float movSpeed;  //speed when grounded
   /* [SerializeField] float airMovSpeed; //speed in the air
    [SerializeField] float movAccel; // maximum change in velocity while on the ground
    [SerializeField] float airMovAccel; // maximum change in velocity while in air */

    private Rigidbody2D rb2d;
    // bool isGrounded; // true when character is on the ground

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2d.AddForce(movement * movSpeed);
    }



  



}
