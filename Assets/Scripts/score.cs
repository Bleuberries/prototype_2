using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
using System.Collections.Generic;

public class score : MonoBehaviour

    {
    diceRoll dice;
    [SerializeField] TMP_Text scoreText;

    public void Awake()
    {
        dice = FindObjectOfType<diceRoll>();
    }

    public void Update()
    {
        if (dice != null)
        {
            if (dice.diceFaceNum != 0)
            {
                scoreText.text = dice.diceFaceNum.ToString();
            }
        }
    }
}
