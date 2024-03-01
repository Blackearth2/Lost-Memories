using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Photon.Pun;

public class movement : MonoBehaviour
{
    PhotonView view;
    public NavMeshAgent agent;
    public float rotateSpeedMovement = 0.05f;
    private float rotateVelocity;
    public Camera cameratatak;

    public Animator anim;
   
    void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
        anim = gameObject.GetComponent<Animator>();
        view = gameObject.GetComponent<PhotonView>();
    }

    void Update()
    {
        if (view.IsMine)
        { 
        
            Animation();
            Move();
        }
    }

    public void Animation()
    {
        float speed = agent.velocity.magnitude / agent.speed;
        //anim.SetFloat("Speed", speed, motionSmoothTime, Time.deltaTime);
    }

    public void Move()
    {
        if(Input.GetMouseButtonDown(1))
        {
            
            RaycastHit hit;

            if(Physics.Raycast(cameratatak.ScreenPointToRay(Input.mousePosition), out hit, Mathf.Infinity))
            {
                
                if(hit.collider.tag == "Terrain")
                {

                    agent.SetDestination(hit.point);
                    agent.stoppingDistance = 0;
                }
            }
        }
    }
}