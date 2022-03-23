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
    bool hitOnce = false;


    private void Awake()
    {
        PlayerCollision.OnDeath += GameOverBehaviour;
    }

    void Start()
    {
        //FindObjectOfType<PlayerCollision>().OnDeath += GameOverBehaviour;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * enemyStats.enemyspeed * Time.deltaTime);
        //DetectPlayer();
    }

    private void GameOverBehaviour()
    {
        Debug.Log("Yo EnemyController recibi la notificacion hago mi parte y por cierto FFFFFFF");
        this.enabled = false;
    }
}
