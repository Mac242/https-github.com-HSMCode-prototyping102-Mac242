using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{

public GameObject car; //red car
private Transform target;

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
        transform.position = target.TransformPoint(offset);
        transform.LookAt(target);
    }
}
