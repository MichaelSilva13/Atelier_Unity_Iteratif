using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public float turnSpeed = 4.0f;
    public Transform player;
 
    public Vector3 offset;
 
    void Start () {
        
    }
 
    void LateUpdate()
    {
        //TODO this session
        //offset = Quaternion.AngleAxis ( , ) * offset;
        
    }
}
