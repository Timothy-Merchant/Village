using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Engine : MonoBehaviour
{
    [SerializeField]
    public UIHandler uIHandler;
    public List<GameObject> players;
    public GameObject testPlayer1;
    public Player testPlayer1Logic;
    public GameObject testPlayer2;
    public GameObject testPlayer3;
    public GameObject testPlayer4;
    public GameObject testPlayer5;
    public GameObject testPlayer6;
    public float turnCounter = 4f;

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

        // Set initial test player status to active
        testPlayer1Logic.isActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        // Set UI counter to remaining moves
        turnCounter = testPlayer1Logic.movesRemaining;

        // Deduct from remaining moves on move
        if (testPlayer1Logic.didMove)
        {
            if (testPlayer1Logic.movesRemaining > 1)
            {
                testPlayer1Logic.movesRemaining -= 1;
            }
            else
            {
                testPlayer1Logic.movesRemaining = 0;
                testPlayer1Logic.isActive = false;
            }

            testPlayer1Logic.didMove = false;
        }
    }
}
