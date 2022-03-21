using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject rayCastOrigin;
    //[SerializeField] public float carSpeed = 2f;
    //[SerializeField] public float gyroSpeed = 2f;
    //[SerializeField] public float raycastRange = 15f;
    bool oneScore = false;
    [SerializeField] protected PlayerData playerStats;
    void Start()
    {
        
    }

    void Update()
    {
        //MovementPlayer1();
        MovementPlayer2();
        DetectEnemy();
    }

    private void MovementPlayer1()
    {
        transform.Translate(Vector3.forward * playerStats.carSpeed * Time.deltaTime);
    }

    private void MovementPlayer2()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Time.deltaTime * playerStats.gyroSpeed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * playerStats.gyroSpeed);
        }
    }

    private void DetectEnemy()
    {
        
        RaycastHit hit;
        if (Physics.Raycast(rayCastOrigin.transform.position, Vector3.left, out hit, playerStats.raycastRange))
        {
            if (GameObject.FindWithTag("Enemy"))
            {
                
                if (oneScore == false)
                {
                    GameManager.instance.score++;
                    oneScore = true;
                    Debug.Log("Sumo punto");
                }
                
            }
            else if (oneScore == true)
            {
                oneScore = false;
                Debug.Log("No sumo punto");
            }
        }
        

        if (Physics.Raycast(rayCastOrigin.transform.position, Vector3.right, out hit, playerStats.raycastRange))
        {
            if (GameObject.FindWithTag("Enemy"))
            {
                if (oneScore == false)
                {
                    GameManager.instance.score++;
                    oneScore = true;
                    Debug.Log("Sumo punto");
                }
            }
            else if (oneScore == true)
            {
                oneScore = false;
                Debug.Log("No sumo punto");
            }
        }
        
    }
}
