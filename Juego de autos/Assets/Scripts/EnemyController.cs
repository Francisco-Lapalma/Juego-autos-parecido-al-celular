using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    //[SerializeField] private float enemyspeed = 2f;
    //bool oneScore = false;
    [SerializeField] private GameObject rayCastOrigin;
    //[SerializeField] private float raycastRange = 15f;
    [SerializeField] protected EnemyData enemyStats;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * enemyStats.enemyspeed * Time.deltaTime);
        //DetectPlayer();
    }

    private void DetectPlayer()
    {
        RaycastHit hit;
        bool oneScore = false;
        if (Physics.Raycast(rayCastOrigin.transform.position, Vector3.left, out hit, enemyStats.raycastRange))
        {
            if (CompareTag("Player"))
            {
                if (oneScore == false)
                {
                    GameManager.instance.score++;
                    oneScore = true;
                    Debug.Log("Sumo punto");
                }

            }
        }

        if (Physics.Raycast(rayCastOrigin.transform.position, Vector3.right, out hit, enemyStats.raycastRange))
        {
            if (CompareTag("Player"))
            {   
                if (oneScore == false)
                {
                    GameManager.instance.score++;
                    oneScore = true;
                    Debug.Log("Sumo punto");
                }
                
            }
        }
    }
}
