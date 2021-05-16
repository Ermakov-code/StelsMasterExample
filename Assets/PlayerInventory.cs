using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{

    public delegate void OnKeyTake();
    public static event OnKeyTake OnKeyTakeEvent;
    
    
    private int currentKeyCount = 0;
 
    public int CurrentKeyCount
    {
        get
        {
            return currentKeyCount;
        }
        private set
        {
            currentKeyCount = value;
        }
    }
    
    public static PlayerInventory singleton = null;

    private void Awake()
    {
        if (singleton == null)
        {
            singleton = this;
        }
    }
    
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Key"))
        {
            CurrentKeyCount++;
            OnKeyTakeEvent?.Invoke();
            ParticleLogicForKeys.particleSystem.PlayParticle(other.transform);
            other.gameObject.SetActive(false);
        }
    }
}
