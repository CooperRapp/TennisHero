using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : MonoBehaviour
{
    public static bool ableToSwing = false;

     void OnTriggerEnter2D(Collider2D other) 
    {
        ableToSwing = true;
    }

    void OnTriggerExit2D(Collider2D other) 
    {
        ableToSwing = false; 
    }
}
