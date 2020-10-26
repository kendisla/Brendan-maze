using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //put variables here
    public float s;
    public float rs;
    Rigidbody rb;

    void Start()
    {
        //initialize variables here
        s = 4f; /* change the 4 to whatever you want */
        rs = 40f; /* this is how many degrees you turn per second, change the 40 to whatever you want */
        rb = GetComponent<Rigidbody>();

}
    void Update()
        {
            //Input.GetKey returns true if the key is being pressed down during that frame
            if (Input.GetKey(KeyCode.W))
            {
                //move forward line
                rb.MovePosition(transform.position + transform.forward * s * Time.deltaTime);  /* this one goes forward */
            }
            else if (Input.GetKey(KeyCode.S))
            {
            //move back line
            rb.MovePosition(transform.position - transform.forward * s * Time.deltaTime); /* this one goes backwards */
            }
            if (Input.GetKey(KeyCode.A))
            {
                //rotate left line
                transform.Rotate( /* is this one positive or negative? */
                Vector3.up * rs *Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.D))
            {
            //rotate right line
            transform.Rotate(/* is this one positive or negative? */ -Vector3.up * rs * Time.deltaTime);
            }
        }
    }

