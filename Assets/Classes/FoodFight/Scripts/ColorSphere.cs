using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSphere : MonoBehaviour
{
    private Material sphereMaterial;
    public Color defaultColor;
    //private Color displayColor;
    public ColoredCubes touchObject;
    //private GameObject sphere;

    // Start is called before the first frame update
    void Start()
    {
        sphereMaterial = GetComponent<MeshRenderer>().material;
        sphereMaterial.color = defaultColor;

    }

    public void onDisplayStart()
    {
        Debug.Log("Enter onDisplayStart!");
        sphereMaterial.color = touchObject.cubeColor;
 
    }

    public void onDisplayEnd()
    {
        sphereMaterial.color = defaultColor;
    }
    //Color SetColor(Color specifiedColor)
    //{
    //    objectMaterial.color = specifiedColor;
    //    Debug.Log("setColor function called!!");
    //    return specifiedColor;
        
    //}

    // Update is called once per frame
    void Update()
    {
        
    }
}
