using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPruebaPlayer : MonoBehaviour
{
    // Start is called before the first frame update

    
    private float raycastRange = 15f;
    [SerializeField] private GameObject rayCastOrigin;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void DetectEnemy()
    {
        bool hitEnemy = false;
        RaycastHit hit;
        // ------------ Later
        bool rayHit = Physics.Raycast(rayCastOrigin.transform.position, rayCastOrigin.transform.TransformDirection(Vector3.left), out hit, raycastRange);
        if(rayHit && !hitEnemy)
        {
            AddPoint(); // Do whatever
            hitEnemy = true;
        } else if(!rayHit)
        {
            hitEnemy = false;
        }

        bool rayHit2 = Physics.Raycast(rayCastOrigin.transform.position, rayCastOrigin.transform.TransformDirection(Vector3.right), out hit, raycastRange);
        if(rayHit2 && !hitEnemy)
        {
            AddPoint(); // Do whatever
            hitEnemy = true;
        } else if(!rayHit)
        {
            hitEnemy = false;
        }
    }

    private void AddPoint()
    {
        GameManager.instance.score += 1;
    }
}
