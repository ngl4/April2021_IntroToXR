using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRTouchCubes : MonoBehaviour
{
    private ColoredCubes touchObject;
    public ColorSphere displayObject;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        var hoveredObject = other.GetComponent<ColoredCubes>();
        
        if (hoveredObject != null)
        {
            touchObject = hoveredObject;
            touchObject.onHoverStart();
            displayObject.touchObject = touchObject;
            displayObject.onDisplayStart();
            Debug.Log("hovered cube");
        }
        
    }

    public void OnTriggerExit(Collider other)
    {
        var hoveredObject = other.GetComponent<ColoredCubes>();

        if (hoveredObject != null)
        {
            touchObject.onHoverEnd();
            displayObject.touchObject = touchObject;
            displayObject.onDisplayEnd();
            touchObject = null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
