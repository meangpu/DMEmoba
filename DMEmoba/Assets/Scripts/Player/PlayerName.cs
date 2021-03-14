using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerName : MonoBehaviour
{
    public TextMeshPro idPlayer;
    public string idKey;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeName(string newName)
    {
        idPlayer.text = newName;
        idKey = newName;
    }
}
