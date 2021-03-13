using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Engine : MonoBehaviour
{

    public List<GameObject> players;
    public GameObject testPlayer1;
    public GameObject testPlayer2;
    public GameObject testPlayer3;
    public GameObject testPlayer4;
    public GameObject testPlayer5;
    public GameObject testPlayer6;

    // Start is called before the first frame update
    void Start()
    {        
        Person Rowena = new Person();
        Rowena.first_name = "Rowena";
        Rowena.last_name = "Rowena";
        Debug.Log(Rowena.first_name);

        players.Add(testPlayer1);
        players.Add(testPlayer2);
        players.Add(testPlayer3);
        players.Add(testPlayer4);
        players.Add(testPlayer5);
        players.Add(testPlayer6);

        testPlayer1.GetComponent<PersonController>().isActive = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
