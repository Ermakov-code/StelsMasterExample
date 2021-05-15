using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoorController : MonoBehaviour
{
    [SerializeField] private GameObject rightDoor;
    [SerializeField] private GameObject leftDoor;

    private void OnEnable()
    {
        GameEvents.gameEvents.OnDoorTriggerEnter += OnDoorOpen;
    }

    private void OnDisable()
    {
        GameEvents.gameEvents.OnDoorTriggerEnter -= OnDoorOpen;
    }

    private void OnDoorOpen()
    {
        rightDoor.transform.DOMove(rightDoor.transform.position + Vector3.left * 2, 1f);
        leftDoor.transform.DOMove(leftDoor.transform.position + Vector3.right * 2, 1f);
    }
}
