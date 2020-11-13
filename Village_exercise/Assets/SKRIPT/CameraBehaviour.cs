using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{

public GameObject car; //red car
private Transform target; // variable to save world position transform of our car

//offset from local point of car to camera position
private Vector3 offset = new Vector3(0f,2,-5f); 

    // Start is called before the first frame update
    void Start()
    {
        target = car.transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
       // transform.position = car.transform.position + offset;

       // set camera to the position of car with offset, converted to world space
        transform.position = target.TransformPoint(offset);

        // Look at our cars transform position
        transform.LookAt(target);
    }
}
