using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColoredCubes : MonoBehaviour
{
    [SerializeField]
    public Color cubeColor;
    public Color defaultColor;
    private Material objectMaterial;
    //public ColorSphere sphereColor;

    // Start is called before the first frame update
    void Start()
    {
        objectMaterial = GetComponent<Renderer>().material;
        objectMaterial.color = cubeColor;
    }

    public void onHoverStart()
    {
        objectMaterial.color = cubeColor;
        //Debug.Log(cubeColor);
        //Color localCubeColor = cubeColor;
        //sphereColor.SetColor(localCubeColor);
    }

    public void onHoverEnd()
    {
        objectMaterial.color = cubeColor;
        //Debug.Log(cubeColor);
        //sphereColor.setColor(cubeColor);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
