using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{    
    public PersonController controller; 
    public float movesRemaining;
    public bool didMove = false;
    public bool isActive = false;

    // Start is called before the first frame update
    void Start()
    {
        movesRemaining = 4;
        controller = this.GetComponent<PersonController>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
