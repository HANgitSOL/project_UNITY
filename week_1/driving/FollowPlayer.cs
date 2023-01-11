using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject player; // get reference
    // drag the reference in UNITY console
    private Vector3 offset = new Vector3(0,5,-7);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate() // make the sequence of update robust - this change make movement of camera surely after the movement of reference
    {
        // transform.position = player.transform.position; // set the camera's position same with player(reference)'s position - this method looks bad..
        // transform.position = player.transform.position + new Vector3(0,5,-7); // make view batter..
        // unity will present you the error message if you type (0,5,-7) instead of new Vector3(0,5,-7)
        // it said that the Vector3 and (0,5,-7) are not able to be intergrated
        transform.position = player.transform.position + offset; // this was recommended
    }
}
