using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbableObject : MonoBehaviour
{
    public Color hoverColor;
    public Color nonHoverColor;

    private Material objectMaterial;

    // Start is called before the first frame update
    void Start()
    {
        objectMaterial = GetComponent<Renderer>().material;
        
    }

    public void onHoverStart()
    {
        objectMaterial.color = hoverColor;
    }

    public void onHoverEnd()
    {
        objectMaterial.color = nonHoverColor;
    }

    public void Grab()
    {

    }

    public void Release()
    {

    }


}
