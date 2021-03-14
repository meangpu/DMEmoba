using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillBoard : MonoBehaviour
{
    public Transform cam;

    private void LateUpdate() 
    {
        if (cam == null)
        {
            cam = GameObject.Find("Main Camera").GetComponent<Transform>();
        }
        else
        {
            transform.LookAt(transform.position + cam.forward);
        }
        
    }

}
