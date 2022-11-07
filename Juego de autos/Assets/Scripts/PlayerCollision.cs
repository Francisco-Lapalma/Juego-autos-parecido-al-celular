using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class PlayerCollision : MonoBehaviour
{ 
    // Start is called before the first frame update
    private void Start() {
        GameManager.instance.score = 0;
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(name + " COLISION CON " + other.gameObject.name);
        if (other.gameObject.CompareTag("Enemy"))
        {
            SceneManager.LoadScene(sceneBuildIndex: 0);
        }
        /*
        if (other.gameObject.CompareTag("Ground"))
        {
            gameObject.GetComponent<PlayerCharacter>().SetJumpStatus(true);
        }
        */
    }
    /*
    private void OnCollisionExit(Collision other)
    {
        Debug.Log(name + " EXIT COLISION CON " + other.gameObject.name);
        if (other.gameObject.CompareTag("Ground"))
        {
            gameObject.GetComponent<PlayerCharacter>().SetJumpStatus(false);
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(name + " Tigger con" + other.gameObject.name);
        Destroy(other.gameObject);
    }
    */
}
