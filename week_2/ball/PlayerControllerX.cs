using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private DateTime TimeRestrict = System.DateTime.Now.TimeOfDay;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DateTime thisTime = System.DateTime.Now.TimeOfDay;
            if (thisTime - TimeRestrict > 5)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            }
            DateTime TimeRestrict = System.DateTime.Now.TimeOfDay;
        }
    }
}
