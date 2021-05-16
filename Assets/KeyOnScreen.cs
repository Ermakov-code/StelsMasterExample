using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyOnScreen : MonoBehaviour
{

    private Text keyCountText;
    private int keyCount = 0;

    private void Start()
    {
        keyCountText = GetComponent<Text>();
    }

    private void OnEnable()
    {
        PlayerInventory.OnKeyTakeEvent += AddKeyToScreen;
    }

    private void OnDisable()
    {
        PlayerInventory.OnKeyTakeEvent -= AddKeyToScreen;
    }

    private void AddKeyToScreen()
    {
        keyCountText.text = "Keys: " + ++keyCount + " / " + GameEvents.gameEvents.KeyToCollect();
    }
    
    
}
