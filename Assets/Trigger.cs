using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    // ������������ ����������� � ���������
    // myTrigger - ���������, ������� ����������
    void OnTriggerEnter(Collider myTrigger)
    {
        if (myTrigger.gameObject.name == "Box")
        {
            Debug.Log("Box went through!");
        }
    }

}
