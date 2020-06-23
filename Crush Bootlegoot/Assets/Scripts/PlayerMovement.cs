using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float movSpeed = 5f;
    public float jumpSpeed = 2f;
    public GameObject crash;
    public Rigidbody2D rb2d;
    public bool inAir = false;

    
    

    void Start()
    {
        
    }

    void Update()
    {
        /*float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2d.AddForce(movement * movSpeed); */

        if(Input.GetButton("Horizontal"))
        {
            crash.transform.position += new Vector3(movSpeed * Time.deltaTime * Input.GetAxis("Horizontal"), 0, 0);
        }

        if(Input.GetButton("Jump") && !inAir)
        {
            rb2d.AddForce(new Vector2(0f, jumpSpeed));
            inAir = true;
            Debug.Log("In Air = true");
        }

       
    }      

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            inAir = false;
            Debug.Log("In Air = ");
        }
    }







}
