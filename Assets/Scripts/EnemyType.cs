using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyType : MonoBehaviour
{
    protected abstract void Attack();
    protected abstract void MoveAround();
    protected abstract void Ability();
}
