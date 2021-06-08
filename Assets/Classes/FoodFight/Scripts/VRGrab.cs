using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRGrab : MonoBehaviour
{
    private VRInput controller;
    private GrabbableObject hoveredObject;
    private GrabbableObject grabbedObject;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<VRInput>();

        controller.onGripDown.AddListener(Grab);
        
    }
    public void OnTriggerEnter(Collider other)
    {
        var grabbable = other.GetComponent<GrabbableObject>();
        if (grabbable != null)
        {
            hoveredObject = grabbable;
            hoveredObject.onHoverStart();
            //Debug.Log("hovered! ");
        }
    }
    public void OnTriggerExit(Collider other)
    {
        var grabbable = other.GetComponent<GrabbableObject>();

        if (grabbable != null)
        {
            hoveredObject.onHoverEnd(); //place onhoverend before hoveredObject set to null 
            hoveredObject = null;
            //Debug.Log("not hovered!");
        }
        
    }

    public void Grab()
    {
        Debug.Log("Grab!");
    }


    // Update is called once per frame
    //void Update() // way to comment multiple lines of code is CTRL + C + E
    //{
        
    //}
}
