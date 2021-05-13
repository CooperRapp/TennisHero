using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwing : MonoBehaviour  {
   
    public Ball ball;
    public Animator animator;
    public GameObject swingPoint;
    public Collider2D swingArea;

    bool swinging;
    float swingTimer = 0;
    float swingCD = 2f;

    void Update() 
    {
        Swing();
    }

    void Swing()
    {         
        if(Input.GetMouseButtonDown(0) && !swinging)
        {
            if(PlayerPaddle.ableToSwing)
            {
                ball.xSpeed *= -1;
                ball.ySpeed *= -1;
            }
            swinging = true;
            swingArea.enabled = true;
            swingTimer = swingCD;

            animator.SetTrigger("swing");
        }

        if(swinging)
        {
            if(swingTimer > 0)
            {
                swingTimer -= Time.deltaTime;
            }
            else 
            {
                swinging = false;
                swingArea.enabled = false;
            }
        }
    }
} 