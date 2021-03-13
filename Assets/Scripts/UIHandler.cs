using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIHandler : MonoBehaviour
{
    public TextMeshProUGUI turnCounter;
    public int turns = 4;

    void Start()
    {
    }

    void Update()
    {
        this.turnCounter.text = turns.ToString();
    }
}
