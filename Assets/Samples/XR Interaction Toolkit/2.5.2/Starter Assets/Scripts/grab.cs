using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class grab : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.activated.AddListener(x=>StartInteract());
        grabInteractable.deactivated.AddListener(x=>EndInteract());



    }
    public void StartInteract()
    {
        Debug.Log("start");
    }
    public void EndInteract() 
    {
        Debug.Log("end");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
