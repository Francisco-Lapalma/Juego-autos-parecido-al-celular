using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Player Data", menuName = "Create Player Data")]
public class PlayerData : ScriptableObject
{
    [SerializeField] public float carSpeed = 2f;
    [SerializeField] public float gyroSpeed = 2f;

}
