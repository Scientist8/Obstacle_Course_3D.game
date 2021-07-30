using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer theRenderer;
    Rigidbody theRigidBody;

    [SerializeField] float timeToWait = 5f;

    void Start()
    {
        theRenderer = GetComponent<MeshRenderer>();
        theRigidBody = GetComponent<Rigidbody>();

        theRenderer.enabled = false;
        theRigidBody.useGravity = false;

    }

    void Update()
    {
        if (Time.time > timeToWait)
        {
            theRenderer.enabled = true;
            theRigidBody.useGravity = true;
        }
    }
}
