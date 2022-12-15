using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.Events;

public class ButtonVR : MonoBehaviour
{

    public GameObject button;
    public UnityEvent onPress;
    public UnityEvent onRelease;
    GameObject presser;
    AudioSource sound;
    bool isPressed;

    public string tagName;

    // Start is called before the first frame update
    void Start()
    {
        sound= GetComponent<AudioSource>();
        isPressed= false; 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isPressed && other.tag != tagName)
        {
            //Debug.Log(other.tag);
            button.transform.localPosition = new Vector3(0, 0.003f, 0);
            presser = other.gameObject;
            onPress.Invoke();
            sound.Play();
            isPressed= true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject == presser) 
        {
            button.transform.localPosition = new Vector3(0,0.04f,0);
            onRelease.Invoke();
            isPressed= false;
        }
    }

    public void ButtonFunction()
    {
        //Debug.Log("pressed");
    }

}
