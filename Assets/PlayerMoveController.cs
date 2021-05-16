using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(PlayerAnimationHandler))]
public class PlayerMoveController : MonoBehaviour
{
    private NavMeshAgent _agentPlayer;
    private PlayerAnimationHandler _animationHandler;
    private void Start()
    {
        _agentPlayer = GetComponent<NavMeshAgent>();
        _animationHandler = GetComponent<PlayerAnimationHandler>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 1000f, LayerMask.GetMask("Floor")));
            {
                _agentPlayer.destination = hit.point;
            }
        }

        if (!_agentPlayer.hasPath)
        {
            _animationHandler.Move(false);
        }
        else
        {
            _animationHandler.Move(true);
        }
    }
}
