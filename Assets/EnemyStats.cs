using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyStats : MonoBehaviour
{
    [SerializeField] protected int Health;
    [SerializeField] protected int Attack;
    [SerializeField] protected int Defence;
    [SerializeField] protected float Speed;
}