using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class VRInput : MonoBehaviour
{
    public Hand hand = Hand.Left;

    private string gripButton;
    private string gripAxis;

    public float gripValue;

    public UnityEvent onGripDown;

    // Start is called before the first frame update
    void Start()
    {
        gripButton = $"{hand}GripButton";
        // dollar sign and quotation means that we can stick variables in here and turn it into a string

        gripAxis = $"{hand}Grip";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown(gripButton))
        {
            onGripDown?.Invoke();
            //Debug.Log("gripButton is clicked: " + gripButton);
        }

        gripValue = Input.GetAxis(gripAxis);
    }
}

[System.Serializable]
public enum Hand    //enum is a data type and it is used to store information 
{
    Left,
    Right
}
