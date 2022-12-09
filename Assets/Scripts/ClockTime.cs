using UnityEngine;
using TMPro;

public class ClockTime : MonoBehaviour
{
    [Header("make sure to use 00:00 form")]
    public string time;
    [SerializeField] TMP_Text display;

    // Start is called before the first frame update
    void Start()
    {
        display.text = time;
        display.gameObject.SetActive(false);
    }

}
