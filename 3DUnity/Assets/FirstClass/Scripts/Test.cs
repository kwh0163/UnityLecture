using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Monster 
{ 
    public Monster()
    {
        Debug.Log("Monster »ý¼ºµÊ");
    }
}

public class Test : MonoBehaviour
{
    public int value = 100;
    public int data = 200;
    void Start()
    {
        Debug.Log(value + " " + data);
        Monster monster = new Monster();
    }

    void Update()
    {
        
    }
}
