using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KeyboardKey : MonoBehaviour
{
    public string key;
    [SerializeField] TMP_Text textBox;
    [SerializeField] GameObject screen;
    // Start is called before the first frame update
    void Start()
    {
        textBox.text = key;
    }

    public void ButtonPress()
    {
        //Debug.Log(key);

        if(key != "DEL")
        {
            screen.GetComponent<CodeController>().currentText += key;
        }
        else
        {
            screen.GetComponent<CodeController>().currentText = "";
        }
    }
}
