using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public float xSpeed = -1.0f;
    public float ySpeed = 0.2f;

    float returnChance;
    
    // Update is called once per frame
    void Update()  
    {
        transform.Translate(xSpeed * Time.fixedDeltaTime, ySpeed * Time.fixedDeltaTime, 0);
    }

    /*
    void OnTriggerEnter2D(Collider2D other) {

        if(returnChance == 1 || returnChance == 2 || returnChance == 3) {

            if(other.CompareTag("Enemy")) {

                if(other.gameObject == null || gameObject == null || gameObject != null) {

                    Destroy (other.gameObject);
                    Destroy (gameObject);

                }

            }

        }
        else if(returnChance == 0) {

            if(other.CompareTag("Enemy")) {

                xSpeed *= -1;

            }

        }

    }*/

}
