using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private Variables
    private float speed = 15.0f; // should type 'f' after the number to let computer know the assigned information is float
    private float turnSpeed = 25.0f;
    // if the turnSpeed was not defined, you should use variable slider in playing to make object turn
    private float horizontalInput; // control the left or right movement - movement on z-axis of object
    private float forwardInput; // control the forward or backward movement

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // Player Input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Move the vehicle forward
        // transform.Translate(0,0,1); // make object move one unit per frame update
        // transform.Translate(Vector3.forward); // easier method
        // transform.Translate(Vector3.forward * Time.deltaTime * speed); // make the movement slow down.. you can enter exact number rather 'speed'
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput); // modulate the movement speed - this does not provide the automated movement
        // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed); // make vehicle turn
        // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        // now i can manipulate the movement of object
        // note: the turnSpeed must have a value larger than 0, or the object will not turn
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput); // rotate the object instead move
    }
}
