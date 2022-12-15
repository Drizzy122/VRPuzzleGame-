using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorController : MonoBehaviour
{
    [Header("this GameObject will open the door")]
    public GameObject key;
    AudioSource sound;

    private void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == key) 
        {
            Debug.Log("Door Open");
            sound.Play();
        }
    }
}
