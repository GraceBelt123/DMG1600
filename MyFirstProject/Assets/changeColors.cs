using UnityEngine;
using System.Collections;

public class changeColors : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            GetComponent<Renderer>().material.color = Color.red;
        if (Input.GetKeyDown(KeyCode.G))
            GetComponent<Renderer>().material.color = Color.green;
        if (Input.GetKeyDown(KeyCode.B))
            GetComponent<Renderer>().material.color = Color.blue;
        // turns object white
        if (Input.GetKeyDown(KeyCode.Backspace))
            GetComponent<Renderer>().material.color = Color.white;
        //turns object black
        if (Input.GetKeyDown(KeyCode.Space))
            GetComponent<Renderer>().material.color = Color.black;
        //turns object yellow
        if (Input.GetKeyDown(KeyCode.Return))
            GetComponent<Renderer>().material.color = Color.yellow;
    }

}
  
