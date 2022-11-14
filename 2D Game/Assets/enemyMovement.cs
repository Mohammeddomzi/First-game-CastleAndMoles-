using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{

    
    public float Speed;
    public Transform[] moveSpots;
    Vector2 movement;
    public Animator animator;

    int index = 1;
    
    void Start()
    {
    
    }

    void Update()
    {
        movement = moveSpots[index].position - transform.position;
        animator.SetFloat("V",movement.y);
        animator.SetFloat("Speed",Speed);
    }
    void FixedUpdate() {


        transform.position = Vector2.MoveTowards(transform.position, moveSpots[1].position,Speed* Time.deltaTime);

    
    }
}
