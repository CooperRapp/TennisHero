using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnAI : MonoBehaviour
{
    public Transform returnPosition;
    public Animator animator;

    public Collider2D netCollider;
    public Collider2D ballCollider;

    BoxCollider2D enemyCollider;

    public GameObject ball;
    public Ball tennisBall;

    bool returnBall = false;
    float speed = 5f;

    float distance;

    void Start() 
    {
        enemyCollider = gameObject.GetComponent<BoxCollider2D>();
        animator = gameObject.GetComponent<Animator>();
    }
    
    void Update() 
    {   
        reposition();
    }

    void onOtherSide()
    {
        if(netCollider.IsTouching(ballCollider))
        {
            returnBall = true;
            Debug.Log("pass net");
        }
        else returnBall = false;
    }

    void moveTowardsBall() 
    { 
    }

    void checkDistance() 
    {
        distance = Vector3.Distance(transform.position, ball.transform.position);
    }
   
    void reposition()
    {
        if(enemyCollider.IsTouching(ballCollider) && !returnBall) 
        {
            returnBall = true;
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.05f, transform.position.z);

            animator.SetTrigger("swing");
            tennisBall.xSpeed *= -1;
            tennisBall.ySpeed *= -1;
        }
        else if(enemyCollider.IsTouching(ballCollider) && returnBall)
        {
            transform.position = Vector3.MoveTowards(transform.position, returnPosition.position, 3f * Time.fixedDeltaTime);
        }
        transform.position = Vector3.MoveTowards(transform.position, ball.transform.position, 1.5f * Time.fixedDeltaTime);
    }
}
