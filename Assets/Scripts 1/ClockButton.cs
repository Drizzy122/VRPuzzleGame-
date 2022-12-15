using UnityEngine;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;

public class ClockButton : MonoBehaviour
{
    [Header("this GameObject will open turn on clock")]
    [SerializeField] GameObject button;
    [SerializeField] TMP_Text display;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == button)
        {
            Debug.Log("clock on Open");
            display.gameObject.SetActive(true);
            DisableButton();


        }
    }
    private void DisableButton()
    {
        button.GetComponent<XRGrabInteractable>().enabled = false;
        button.GetComponent<Rigidbody>().isKinematic = true;
        button.GetComponent<BoxCollider>().enabled = false;
        button.GetComponent<CapsuleCollider>().enabled = false;
        button.transform.localPosition = new Vector3(1.05799997f, 0.177000001f, 0);
        button.transform.localRotation = new Quaternion(0.5f, 0.5f, 0.5f, 0.5f);


    }
}
