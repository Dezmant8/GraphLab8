using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUITextExample : MonoBehaviour
{
    public Text MyText;
    private int Counter = 0;
    void Update()
    {
        ++Counter;
        MyText.text ="Counter is:" + Counter;
    }
}
