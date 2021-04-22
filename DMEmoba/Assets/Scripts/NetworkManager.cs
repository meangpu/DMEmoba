using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Colyseus;
using System;

public class NetworkManager : MonoBehaviour
{

    public Button connectButton;

    private PlayerPosition userPlayerScript;

    public Client client;
    string endPoint = "ws://ivrylobs.xyz:2567";
    public Room<State> room;
    string roomName  = "arena";
    string status = "";
    public bool connectionState = false;
    public TextMeshProUGUI statusText;
    public GameObject otherPlayer;

    public GameObject[] allPlayer;

    // Start is called before the first frame update
    void Start()
    {
        connectButton.onClick.AddListener(ConnectToServer);
        userPlayerScript = GameObject.Find("Player").GetComponent<PlayerPosition>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateStatus();
    }

    async void ConnectToServer()
    {
        status = "Connecting";
        client = new Colyseus.Client(endPoint);
        try {
            room = await client.JoinOrCreate<State>(roomName);
            status = "Connected at " + room.Name + " ID: " + room.SessionId;
            connectionState = true;

            userPlayerScript.ChangeName(room.SessionId);
            room.State.players.OnAdd += OnPlayerAdd;
        } catch (Exception ex) {
            status = "Connection failed";
            Debug.Log(ex);
        }
        
    }

    void UpdateStatus()
    {
        statusText.text = status;
    }

    void OnPlayerAdd(PlayerData player, string key)
    {
        if (key != room.SessionId)
        {
            Vect3 pos = (Vect3)player.position;
            Quat rot = (Quat)player.rotation;
            var newPlayer = Instantiate(otherPlayer, new Vector3(pos.x, pos.y, pos.z), new Quaternion(rot.x, rot.y, rot.z, rot.w));
            newPlayer.name = key;
            newPlayer.GetComponent<PlayerName>().ChangeName(key);
            player.OnChange += (changes) => OnPlayerChange(changes, key);
        }
    }

    void OnPlayerChange(List<Colyseus.Schema.DataChange> changes, string key)
    {
        var objRef = GameObject.Find(key);
        if (key != room.SessionId)
        {
            changes.ForEach( (obj) => {
                if (obj.Field == "position")
                {
                    Vect3 pos = (Vect3)obj.Value;
                    //print("Player " + key + "moved at " + pos.x + ", " + pos.y + ", " + pos.z);
                    objRef.transform.position = Vector3.Lerp(objRef.transform.position, new Vector3(pos.x, pos.y, pos.z), Time.deltaTime * 5);
                } else if (obj.Field == "rotation")
                {
                    Quat rot = (Quat)obj.Value;
                    print("Player " + key + "look at " + rot.x + ", " + rot.y + ", " + rot.z + ", " + rot.w);
                    objRef.transform.rotation = new Quaternion(rot.x, rot.y, rot.z, rot.w);
                }
                
            });
        }
    }
}
