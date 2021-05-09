using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackTrigger : MonoBehaviour  {
   
   public Ball ball;

    void OnTriggerEnter2D(Collider2D other) {
       
        ball = other.GetComponent<Ball>();

        if(ball != null && other.isTrigger == true && other.CompareTag("ball")) {

            ball.xSpeed *= -1;
            ball.ySpeed *= -1;

        }

    }

} 