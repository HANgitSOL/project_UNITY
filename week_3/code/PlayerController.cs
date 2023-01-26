using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody playerRb;
    public float speed = 1.0f;
    private GameObject focalPoint; // get the information of focal point(view point)

    public bool hasPowerup = false;
    private float powerUpStrungth = 15.0f;

    public GameObject powerupIndicator;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");

        playerRb.AddForce(focalPoint.transform.forward * forwardInput * speed);

        powerupIndicator.transform.position = transform.position + new Vector3(0,-0.5f,0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Powerup")) 
        {
            hasPowerup = true; // check whether the player get powerup-gem
            Destroy(other.gameObject); 

            powerupIndicator.gameObject.SetActive(true);
            // present whether the player is powered-up

            // i cannot perform this.. again...

            StartCoroutine(PowerupCountdownRoutine()); // call co-routine
        }
    }

    // use co-routine and limit the time interval of power-up
    IEnumerator PowerupCountdownRoutine()
    {
        yield return new WaitForSeconds(7); // wait for 7 seconds
        hasPowerup = false; // re-set the power-up state

        powerupIndicator.gameObject.SetActive(false);
        // remove presence of power-up
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy") && hasPowerup)
        {
            Rigidbody enemyRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            // get the rigid body of enemy
            Vector3 awayFromPlayer = collision.gameObject.transform.position - transform.position;
            // determine the direction that the enemy will be move (bye bye ~

            enemyRigidbody.AddForce(awayFromPlayer * powerUpStrungth, ForceMode.Impulse); // beat up enemy object

            Debug.Log("Collided with: " + collision.gameObject.name + " with powerup set to " + hasPowerup);
        }
    }
}
