using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float carSpeed = 2f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovementPlayer1();
        MovementPlayer2();
    }

    private void MovementPlayer1()
    {
        transform.Translate(Vector3.forward * carSpeed * Time.deltaTime);
    }

    private void MovementPlayer2()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime);
        }
    }
}
