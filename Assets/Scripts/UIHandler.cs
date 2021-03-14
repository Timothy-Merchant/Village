using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIHandler : MonoBehaviour
{
    [SerializeField]
    public Engine engine;
    public TextMeshProUGUI turnCounter;    

    void Start()
    {
        
    }

    void Update()
    {
        this.turnCounter.text = engine.turnCounter.ToString();
    }
}
