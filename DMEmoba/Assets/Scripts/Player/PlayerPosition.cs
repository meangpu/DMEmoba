using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

class PlayerInputMessage
{
    public Vect3 position;
    public Quat rotation;
}

public class PlayerPosition : MonoBehaviour
{
    public NetworkManager network;
    public TextMeshPro idPlayer;
    public string idKey;

    private readonly float sendInterval = 50 / 1000f;
    private float sendTimer = 0f;

    void Start()
    {
        network = GameObject.Find("NetworkManager").GetComponent<NetworkManager>();
    }

    void Update()
    {
       sendTimer += Time.deltaTime;
    //    if (sendTimer >= sendInterval)
    //    {
           
    //    }
       if (network.connectionState) {
            UpdatePosition(transform.position, transform.rotation);
        }
    }

    void UpdatePosition(Vector3 _pos, Quaternion _rot)
    { 
        PlayerInputMessage msg = new PlayerInputMessage();
        Vect3 pos = new Vect3();
        pos.x = _pos.x;
        pos.y = _pos.y;
        pos.z = _pos.z;
        Quat rot = new Quat();
        rot.x = _rot.x;
        rot.y = _rot.y;
        rot.z = _rot.z;
        rot.w = _rot.w;
        msg.position = pos;
        msg.rotation = rot;
        network.room.Send("input", msg);
    }

    public void ChangeName(string newName)
    {
        idPlayer.text = newName;
        idKey = newName;
    }

}
