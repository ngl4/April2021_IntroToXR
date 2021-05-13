using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Rocket : MonoBehaviour
{
    public float moveSpeed;
    public float turnSpeed;
    public Rigidbody rocketRigidBody;
    void Start()
    {
        // keep the mouse inside of the game view
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); //input.getaxis is always in between -1f (all the way to the left or down), 0 (means nothing - not doing anything) and 1f (all the way to right or up) 
        float vertical = Input.GetAxis("Mouse Y");
        #region Translational movement
        //if (Input.GetKey(KeyCode.W))
        //{
        //    transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
        //}
        //transform.Rotate(Vector3.up * horizontal * turnSpeed);
        //transform.Rotate(Vector3.left * vertical * turnSpeed);
        #endregion
        #region Physics
        Vector3 torque = new Vector3(vertical, horizontal, 0f); //time.deltaTime measures the frame rate (tells you how long between frames), the amount of time since the last frame - only in the update() function - for consistency for every frame rate
        //The interval in seconds from the last frame to the current one
        rocketRigidBody.AddTorque(torque * Time.deltaTime * turnSpeed); //a turning twisting force-spinning on its axis //rotate //rotational/circular force 
        //The higher the frame rate the better. 90 frames per second.
        //frame rate is based on the machine and items in the scene of the game
        //most oculus quest has similar frame rate 
        if (Input.GetKey(KeyCode.W))
        {
            rocketRigidBody.AddForce(Vector3.forward * Time.deltaTime * moveSpeed); // linear - push 
        }
        #endregion
    }
}