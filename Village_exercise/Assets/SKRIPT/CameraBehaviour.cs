using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{

public GameObject car; //red car

//offset from local point of car to camera position
private Vector3 offset = new Vector3(0f,1,-3f); 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = car.transform.position + offset;
    }
}
