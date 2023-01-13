using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using System;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    private float speed = 10.0f;
    public float xRange = 10.0f;
    // private float margin;
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange,transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange,transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        // float margin = Math.Abs(transform.position.x);
        // if (margin < xRange) {
        //     horizontalInput = Input.GetAxis("Horizontal");
        //     transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        //     
        // } else {
        //      transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        // }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation); // copy objects that already exist(prefab)
            // if the second element is missed, the object always present in the same position with original position of that object
            // and if you set second element, you always set third element. the reason is... i don't know
        }
        
    }
}
