using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraRotate : MonoBehaviour
{
    public Transform target;
    public float speed = 10f;

    void Update() 
    {
        transform.RotateAround(target.position, Vector3.up, speed*Time.deltaTime);
    }

}
