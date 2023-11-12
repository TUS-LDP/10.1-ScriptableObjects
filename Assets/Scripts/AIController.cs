using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AIController : MonoBehaviour
{
    public AIProfile theAIProfile;

    // Start is called before the first frame update
    void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.speed = theAIProfile.speed;
        agent.angularSpeed = theAIProfile.angularSpeed;
        agent.acceleration = theAIProfile.acceleration;
        agent.stoppingDistance = theAIProfile.stoppingDistance;
        agent.autoBraking = theAIProfile.autoBraking;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
