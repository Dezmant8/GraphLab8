using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    // Обнаруживаем столновение с триггером
    // myTrigger - коллайдер, который столкнулся
    void OnTriggerEnter(Collider myTrigger)
    {
        if (myTrigger.gameObject.name == "Box")
        {
            Debug.Log("Box went through!");
        }
    }

}
