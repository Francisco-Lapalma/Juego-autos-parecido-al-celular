using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject[] enemys;


    private void Awake()
    {

    }
    void Start()
    {
        SpawnEnemy();
        //PlayerCollision.OnDeath += DisableGenerator;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void SelectRandomEnemys()
    {
        int enemyIndex = Random.Range(0, enemys.Length);
        Instantiate(enemys[enemyIndex], transform.position, transform.rotation);
        Destroy(GameObject.FindGameObjectWithTag("Enemy"), 15f);
    }

    private void SpawnEnemy()
    {
        float randomRate = Random.Range(2f, 10f);
        float randomDelay = Random.Range(0f, 2f);
        InvokeRepeating("SelectRandomEnemys", randomDelay, randomRate);
    }
}
