using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterFollow : MonoBehaviour
{
    private bool following;
    private CharacterController _controller;
    private UnityEngine.AI.NavMeshAgent _agent;

    // Start is called before the first frame update
    void Start()
    {
        _controller = FindAnyObjectByType<CharacterController>();
        _agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (following)
        {
            _agent.SetDestination(_controller.transform.position);

            if (_agent.remainingDistance <= 10 && _agent.remainingDistance >=2)
            {
                _agent.isStopped = false;
            }
            else if (_agent.remainingDistance > 10)
            {
                following = false;
                _agent.isStopped = false;
                _agent.ResetPath();
            }
            else if (_agent.remainingDistance < 2)
            {
                _agent.isStopped = true;
                Debug.Log("Stopping");
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            following = true;
            _agent.SetDestination(_controller.transform.position);
        }
    }
}
