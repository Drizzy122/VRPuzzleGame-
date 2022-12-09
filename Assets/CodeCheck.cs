using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeCheck : MonoBehaviour
{
    public GameObject screenCode;

    [SerializeField] GameObject door;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (screenCode.GetComponent<CodeController>().correct)
        {
            door.SetActive(false);
        }
    }
}
