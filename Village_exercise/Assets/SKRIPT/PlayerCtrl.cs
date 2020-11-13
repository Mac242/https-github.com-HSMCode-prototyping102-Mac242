using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour

{

    public float turnSpeed = 50f; 
    public float speed = 3f; //speed for our red car
    private float verticalInput; // Input of arrow keys up and down
    private float horizontalInput; // Input of L and R arrow keys 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        //move our red car forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        if(verticalInput > 0)
        {
             //move our red car forward left right
            transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput,Space.Self);
            //if I press the arrow keys, my input float is bigger than 0, then do
            // Debug.Log("Vertical Input bigger than null");
        }

        else if(verticalInput < 0)
        {
             //move our red car forward left right
            transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput,Space.Self);
            
            
        }
        
    }
}
