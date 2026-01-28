using UnityEngine;
using System;
public class ControlFlow : MonoBehaviour
{
    public bool flag = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(flag)
        {
            Debug.Log("Boolean flag is set");
        }
        else
        {
            Debug.Log("Boolean flag isn't set");
        }

        for (int i = 1; i<=10; i++)
        {
            double Result = Math.Pow(2, i);
            Debug.Log($"The {i} power of 2 is {Result}");
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
