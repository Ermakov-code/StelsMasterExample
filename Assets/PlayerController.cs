using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;

public class PlayerController : MonoBehaviour {
    
    private NavMeshAgent agent;
    private ThirdPersonCharacter character;
    private float timer;
    [SerializeField] private float timeToNextPath;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    
    void FixedUpdate ()
    {
        
        if (!agent.hasPath)
        {
            PlayerAnimationHandler.AnimationHandlerSingleton.Move(false);
            timer += Time.deltaTime;
            if (timer >= timeToNextPath)
            {
                agent.destination = RandomNavmeshLocation(Random.Range(3f, 10f));
                timer = 0;
            }
        }
        else
        {
            if (agent.remainingDistance > agent.stoppingDistance)
            {
                PlayerAnimationHandler.AnimationHandlerSingleton.Move(true);
            }
        }
    }
    
    
    private Vector3 RandomNavmeshLocation(float radius) {
        Vector3 randomDirection = Random.insideUnitSphere * radius;
        //randomDirection += transform.position;
        NavMeshHit hit;
        Vector3 finalPosition = Vector3.zero;
        if (NavMesh.SamplePosition(randomDirection, out hit, radius, 1)) {
            finalPosition = hit.position;            
        }
        return finalPosition;
    }


    public void MoveToLastPosition(Vector3 lastPosition)
    {
        agent.destination = lastPosition;
    }
}
