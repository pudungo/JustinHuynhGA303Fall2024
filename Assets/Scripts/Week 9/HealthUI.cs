using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthUI : MonoBehaviour
{
    public PlayerRPG playerRPG;
    public TextMeshProUGUI healthText;

    void Start()
    {
        float value = playerRPG.health;
    }


    void Update()
    {
        healthText.text = playerRPG.health.ToString("F3");
    }
}
