using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //intialize float to allow user control of car(object) speed.
    public float speed = 15f;
    //intialize float to allow user control of car(object) turnspeed
    public float turnSpeed = 20f;
    
    //allow player to control object with userinput
    private float horizontalInput;
    private float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //allow player to control object with userinput
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        // move car based on speed variable and user input
        transform.Translate(Vector3.forward * Time.deltaTime*speed* verticalInput);
        // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        // turn car based on speed variable and user input
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
