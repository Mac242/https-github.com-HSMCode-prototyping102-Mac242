using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour

{

    public float turnSpeed = 30f; 
    public float speed = 2f; //speed for our red car
    public float verticalInput; // Input of arrow keys up and down
    public float horizontalInput; // Input of L and R arrow keys 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        //move our red car 
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput,Space.Self);
    }
}
