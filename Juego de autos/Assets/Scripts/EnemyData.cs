using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Enemy Data", menuName = "Create Enemy Data")]
public class EnemyData : ScriptableObject
{
    [SerializeField] public float enemyspeed = 2f;
    [SerializeField] public float raycastRange = 15f;
}
