using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject keycard;
    public GameObject door;
    public Vector3 keycardPos;
    // Start is called before the first frame update
    void Start()
    {
        door.GetComponent<doorController>().key = Instantiate(keycard, keycardPos, Quaternion.Euler(0,0,0));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
