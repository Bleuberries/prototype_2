using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;

public class faceDetector : MonoBehaviour
{
   
    diceRoll dice;

    public void Awake()
    {
        dice = FindObjectOfType<diceRoll>();
    }

    public void OnTriggerStay(Collider other)
    {
        if (dice  != null)
        {
            if (dice.GetComponent<Rigidbody>().linearVelocity == Vector3.zero)
            {
                dice.diceFaceNum = int.Parse(other.name);
            }
        }
    }

}
