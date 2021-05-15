using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{

    public delegate void OnKeyTake();
    public static event OnKeyTake OnKeyTakeEvent;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Key"))
        {
            OnKeyTakeEvent?.Invoke();
            other.gameObject.SetActive(false);
        }
    }
}
