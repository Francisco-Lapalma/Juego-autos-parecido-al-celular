using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grua : EnemyController
{
    // Start is called before the first frame update
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float cadencia = 0.5f;
    void Start()
    {
        InvokeRepeating("Shoot", 0f, cadencia);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Shoot()
    {
        Instantiate(bulletPrefab, Vector3.left, transform.rotation);
        Instantiate(bulletPrefab, Vector3.right, transform.rotation);
    }
}
