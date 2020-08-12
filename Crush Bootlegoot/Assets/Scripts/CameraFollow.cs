using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    private Transform playerTransform;
    public float offset;
    
    
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;   
    }

    
    void LateUpdate() //called after update and fixedupdate
    {
        if (playerTransform != null) 
        {
            //current camera position in temp
            Vector3 temp = transform.position;

            //camera's x now equals player's x
            temp.x = playerTransform.position.x;

            //adds offset to the camera
            temp.x += offset;

            //camera's position set to what is in temp
            transform.position = temp;
        }
    }
}
