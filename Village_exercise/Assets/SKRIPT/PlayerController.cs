using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

public float speed = 1.5f; //speed for our red car
public float verticalInput; // Input of arrow keys up and down
public float horizontalInput; // Input of arrow keys left and right

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
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput * horizontalInput);
    }
}
