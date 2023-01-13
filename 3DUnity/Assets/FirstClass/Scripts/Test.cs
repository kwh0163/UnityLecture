using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Monster 
{ 
    public Monster()
    {
        Debug.Log("Monster ������");
    }
}

public class Test : MonoBehaviour
{
    public int value = 100;
    public int data = 200;
    public int [] count;
    public int [] array = new int[3];
    public float speed = 0.5f;

    void Start()
    {
        Debug.Log(value + " " + data);
        Monster monster = new Monster();

        transform.position = new Vector3(0,1,0);

        foreach (var ele in array) Debug.Log(ele);
        foreach (var ele in count) Debug.Log(ele);


    }

    void Update()
    {
        //GetKeyDown Ű�� ������ ��
        //GetKey Ű�� ������ ���� ��
        //GetKeyUp Ű�� ���� ��
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("�����̽�Ű�� ������");
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 0, speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, 0, -speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-speed,0,0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(speed,0,0);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = 1.5f;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 0.5f;
        }

    }
}
