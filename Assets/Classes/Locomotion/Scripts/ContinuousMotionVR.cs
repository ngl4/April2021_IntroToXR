using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinuousMotionVR : MonoBehaviour
{
    public Transform XRRig;
    //private VRinput controller;

    private Vector3 forwardDirection;
    private Vector3 rightDirection;

    // Start is called before the first frame update
    void Start()
    {
        //controller = GetComponent<VRinput>();
    }

    // Update is called once per frame
    void Update()
    {
        //forwardDirection = controller.transform.forward;
        //normalized 
        forwardDirection.y = 0f;
        forwardDirection.Normalize();

        //rightDirection = controller.transform.right;



    }
}
