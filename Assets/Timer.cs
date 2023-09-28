using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    float currentRaceTime = 0f;
    public TextMeshProUGUI text;

    void Start()
    {
        currentRaceTime = 0f;
    }
    void Update()
    {
        currentRaceTime += Time.deltaTime;

        string time = currentRaceTime.ToString();

            text.text = time[0] + "s";
    }
}
