using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject rayCastOrigin;
    //[SerializeField] public float carSpeed = 2f;
    //[SerializeField] public float gyroSpeed = 2f;
    private float raycastRange = 15f;
    bool oneScore = false;
    bool hitOnce = false;
    [SerializeField] protected PlayerData playerStats;



    private void Awake()
    {

    }
    void Start()
    {
        //FindObjectOfType<PlayerCollision>().OnDeath += GameOverBehaviour;
    }

    void Update()
    {
        //MovementPlayer1();
        MovementPlayer2();
        //DetectEnemy();
        UnlockMovementUpDown();
    }

    private void MovementPlayer1()
    {
        transform.Translate(Vector3.forward * playerStats.carSpeed * Time.deltaTime);
    }

    private void MovementPlayer2()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * playerStats.gyroSpeed);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * playerStats.gyroSpeed);
        }
    }

    private void DetectEnemy()
    {


        RaycastHit hit;


        if (Physics.Raycast(rayCastOrigin.transform.position, rayCastOrigin.transform.TransformDirection(Vector3.right), out hit, raycastRange))
        {
            if (hit.collider.tag == "Enemy" && !hitOnce)
            {

                /////// detecta si el enemy fue tocado por el ray   cast
                Debug.Log("HIT!!!!!");
                ////// cambia el boolean a true asi el if no se ejecuta 
                hitOnce = true;
                //////// suma un punto
                GameManager.instance.score += 1;
                Debug.Log("Sumo punto desde raycast right");

            }

        }
        ///// si no toca ningun auto, el boolean cambia a falso 
        else hitOnce = false;

        if (Physics.Raycast(rayCastOrigin.transform.position, rayCastOrigin.transform.TransformDirection(Vector3.left), out hit, raycastRange))
        {
            if (hit.collider.tag == "Enemy" && !hitOnce)
            {

                /////// detecta si el enemy fue tocado por el ray   cast
                Debug.Log("HIT!!!!!");
                ////// cambia el boolean a true asi el if no se ejecuta 
                hitOnce = true;
                //////// suma un punto
                GameManager.instance.score += 1;
                Debug.Log("Sumo punto desde raycast left");

            }

        }
        ///// si no toca ningun auto, el boolean cambia a falso 
        else hitOnce = false;
    }
    /*
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(rayCastOrigin.transform.position, rayCastOrigin.transform.TransformDirection(Vector3.right) * raycastRange);

        Gizmos.color = Color.blue;
        Gizmos.DrawRay(rayCastOrigin.transform.position, rayCastOrigin.transform.TransformDirection(Vector3.left) * raycastRange);
    }
    */
    private void UnlockMovementUpDown()
    {
        if (GameManager.instance.score >= 3000)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                transform.Translate(Vector3.forward * Time.deltaTime * playerStats.carSpeed);
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                transform.Translate(Vector3.forward * Time.deltaTime * playerStats.carSpeed);
            }
        }
    }
}
