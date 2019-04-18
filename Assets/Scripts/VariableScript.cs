using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableScript : MonoBehaviour
{
    //Seccion de variables
    public int number1 = 5;
    public int number2 = 8;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            AddTwoNumbers();
        }
    }


    void AddTwoNumbers()
    {
        Debug.Log(number1 + number2);
    }
}
