using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyCollisionDetection : MonoBehaviour
{
   
    [SerializeField] private PlayerController agentController;
    [SerializeField] private NavMeshAgent _agent;
    private Vector3 lastPositionOnNavMesh;
    

    private void OnTriggerEnter(Collider other)
    {
        agentController.enabled = false;
        lastPositionOnNavMesh = transform.position;
    }

    private void OnTriggerExit(Collider other)
    {
        agentController.enabled = true;
        agentController.MoveToLastPosition(lastPositionOnNavMesh);
    }

    private void OnTriggerStay(Collider other)
    {
        _agent.destination = other.gameObject.transform.position;
    }
}
