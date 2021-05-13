using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnAI : MonoBehaviour
{
    public Transform returnPosition;
    public Animator animator;

    public Collider2D enemySideCollider;
    public Collider2D ballCollider;

    BoxCollider2D enemyCollider;

    public GameObject ball;
    public Ball tennisBall;

    void Start() 
    {
        enemyCollider = gameObject.GetComponent<BoxCollider2D>();
        animator = gameObject.GetComponent<Animator>();
        enemySideCollider.isTrigger = true;
        enemyCollider.isTrigger = true;
    }
    
    void Update() 
    {   
        returnBall();
    }

    bool onOtherSide()
    {
        if(enemySideCollider.IsTouching(ballCollider))
        {
            return true;
        }
        return false;
    }

    void returnBall() 
    {
        if(onOtherSide())
        {
            transform.position = Vector2.MoveTowards(enemyCollider.transform.position, ball.transform.position, 1.5f * Time.fixedDeltaTime);
        }
        else
        {
            if(Vector2.Distance(transform.position, returnPosition.position) != 0)
            {
                transform.position = Vector2.MoveTowards(enemyCollider.transform.position, returnPosition.position, 1.5f * Time.fixedDeltaTime);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        //transform.position = new Vector2(transform.position.x, transform.position.y - 0.05f);
        animator.SetTrigger("swing");
        tennisBall.xSpeed *= -1;
        tennisBall.ySpeed *= -1;
    }
}
