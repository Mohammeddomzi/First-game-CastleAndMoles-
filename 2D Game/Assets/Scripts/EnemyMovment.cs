using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovment : MonoBehaviour
{
    public float Speed;
    private waypoint wp;

    private int waypointIndex = 1;
    
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        if(gameObject.name == "Enemy"){
        wp = GameObject.FindGameObjectWithTag("waypoint").GetComponent<waypoint>();
        }
        else{
            wp = GameObject.FindGameObjectWithTag("enemy2waypoint").GetComponent<waypoint>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir =  wp.waypoints[waypointIndex].position - transform.position;
        animator.SetFloat("V",dir.y);
        animator.SetFloat("Speed",Speed); 
        transform.position = Vector2.MoveTowards(transform.position,wp.waypoints[waypointIndex].position,Speed *  Time.fixedDeltaTime);
        if(Vector2.Distance(transform.position,wp.waypoints[waypointIndex].position)<0.1f){
            if(waypointIndex == 1){
                waypointIndex = 0;
            }
            else{
                waypointIndex = 1;
            }
            transform.position = Vector2.MoveTowards(transform.position,wp.waypoints[waypointIndex].position,Speed *  Time.fixedDeltaTime);
        }
    }
}
