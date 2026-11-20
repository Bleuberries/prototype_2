using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(Rigidbody))]
public class diceRoll : MonoBehaviour

{
    Rigidbody body;
    [SerializeField] private float maxRandomForceValue, startRollingForce;
    public float forceX, forceY, forceZ;
    public int diceFaceNum;

    public void Awake()
    {
        Initialize();
    }

    public void Update()
    {
        if (body != null)
        {
            if (Input.GetMouseButtonDown(0))
            {
                RollDice();
            }
        }
    }

    public void RollDice()
    {
        body.isKinematic = false;
        forceX = Random.Range(0, maxRandomForceValue);
        forceY = Random.Range(0, maxRandomForceValue);
        forceZ = Random.Range(0, maxRandomForceValue);
        body.AddForce(Vector3.up * startRollingForce);
        body.AddTorque(forceX, forceY, forceZ);
    }

    public void Initialize()
    {
        body = GetComponent<Rigidbody>();
        body.isKinematic = true;
        transform.rotation = new Quaternion(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360), 0);
    }
}

