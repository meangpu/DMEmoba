using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPlayer : MonoBehaviour
{

    public GameObject spawn;
    public Vector3 loc;

    public void spawnNew()
    {
        Instantiate(spawn, loc, Quaternion.identity);
    }
}
