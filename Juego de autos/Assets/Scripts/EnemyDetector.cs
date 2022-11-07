using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetector : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        Debug.Log(name + " TRIGGER CON " + other.gameObject.name);
        if (other != null){
            if (other.gameObject.tag == "Enemy")
            {
                GameManager.instance.score += 1;
            }        
        } 
    }
}
