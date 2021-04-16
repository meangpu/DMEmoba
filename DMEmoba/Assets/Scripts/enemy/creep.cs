using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creep : MonoBehaviour
{
    public GameObject scorePopUp;
    void OnDestroy()
    {
        Instantiate(scorePopUp, transform.position, Quaternion.identity);
        Debug.Log("OnDestroy1");
    }
}
