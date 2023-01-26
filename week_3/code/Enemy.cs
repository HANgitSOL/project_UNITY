using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float speed = 3.0f;
    private Rigidbody enemyRb;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
        // enemyRb.AddForce((player.transform.position - transform.position).normalized * speed); // C# follow the rule of arithmetic operation
        // if you do not normalize the difference between player and enemy, you will get scared..

        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed);

        if(transform.position.y < -10)
        {
            Destroy(gameObject);
        }
        // delete enemy if it drops down
    }
}
