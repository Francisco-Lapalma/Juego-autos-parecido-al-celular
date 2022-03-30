using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecorationsController : MonoBehaviour
{

    private Vector3 startPos;
    [SerializeField] private float decorationSpeed = 5f;

    private void Awake()
    {

    }
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < startPos.z - 60)
        {
            transform.position = startPos;
        }

        transform.Translate(Vector3.back * Time.deltaTime * decorationSpeed);
    }

}
