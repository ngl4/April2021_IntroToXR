using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMouseMovement : MonoBehaviour
{
    float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /**       float horizontalRaw = Input.GetAxisRaw("Mouse X");
               //GetAxisRaw = changes from 0 to 1 or -1 immediately, without steps
               //no smoothing applies, so it is useful if you would like to do all smoothing of keyboard input processing yourself.
               float verticalRaw = Input.GetAxisRaw("Mouse Y");

               float horizontal = Input.GetAxis("Mouse X");
               //GetAxis =  change from 0 to +1 or -1 with increase/decrease in 0.05f steps

               //Vector3 cameraVector = new Vector3 (horizontalRaw, 0.0f, verticalRaw);

               if (horizontal != 0)
               {
                   Debug.Log("detect mouse movement");
                   transform.position += new Vector3(horizontalRaw * Time.deltaTime * speed, 0.0f, verticalRaw * Time.deltaTime * speed);
               }
               else
               {
                   Debug.Log("Nooo mouse movement");

               }
       **/

        if (Input.GetAxis("Mouse X") > 0)
        {
            transform.position += new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * speed,
                                       0.0f, Input.GetAxisRaw("Mouse Y") * Time.deltaTime * speed);
        }

        else if (Input.GetAxis("Mouse X") < 0)
        {
            transform.position += new Vector3(Input.GetAxisRaw("Mouse X") * Time.deltaTime * speed,
                                       0.0f, Input.GetAxisRaw("Mouse Y") * Time.deltaTime * speed);
        }
    }
}
