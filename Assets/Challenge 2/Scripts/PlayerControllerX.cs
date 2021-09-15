using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    float waitTime = 0;

    // Update is called once per frame
    void Update()
    {
        // subtract waited time from wait time
        waitTime -=Time.deltaTime;

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
           // allow spawn after wait time is over
            if(waitTime <= 0)
            {
                SpawnDog();

                //reset wait time
                waitTime = 1;
            } 
        }
    }

void SpawnDog()
    {
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
    }

}
