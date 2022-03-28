using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecorationsController : MonoBehaviour
{
    [SerializeField] private float scrollFactor = -1f;
    [SerializeField] private Vector3 gameVelocity;
    Rigidbody rbDecorations;

    private void Awake()
    {
        rbDecorations = GetComponent<Rigidbody>();
        rbDecorations.velocity = gameVelocity * scrollFactor;
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerExit(Collider gameArea)
    {
        transform.position = Vector3.forward * (gameArea.bounds.size.z - GetComponent<BoxCollider>().size.z);
    }
}
