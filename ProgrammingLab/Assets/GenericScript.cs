using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericScript : MonoBehaviour
{
    private int[] num1 = {1, 2, 3};
    private float[] num2 = {1.1f, 2.2f, 3.3f};
    private string[] num3 = {"1", "2", "3"};

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            KeyPressCheck(num1);
        }
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            KeyPressCheck(num2);
        }
        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            KeyPressCheck(num3);
        }
    }

    public void KeyPressCheck<Key>(Key[] array)
    {
        foreach(Key info in array)
        {
            Debug.Log(info);
        }
    }
}
