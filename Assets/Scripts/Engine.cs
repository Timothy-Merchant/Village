using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engine : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Person Rowena = new Person();
        Rowena.first_name = "Rowena";
        Rowena.last_name = "Rowena";
        Debug.Log(Rowena.first_name);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
