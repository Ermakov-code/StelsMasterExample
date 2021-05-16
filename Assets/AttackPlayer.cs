using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPlayer : MonoBehaviour
{
    [SerializeField] private int damage = 2;

    public static event Action<int> OnPlayerTakeDamage;
    
    private Coroutine _coroutine;
    private void OnTriggerEnter(Collider other)
    {
        _coroutine = StartCoroutine(AttackPlayerRoutine());
    }

    private void OnTriggerExit(Collider other)
    {
        StopCoroutine(_coroutine);
    }


    private IEnumerator AttackPlayerRoutine()
    {
        var waiter = new WaitForSeconds(1f);
        while (true)
        {
            OnPlayerTakeDamage(damage);
            yield return waiter;
        }
    }
}
