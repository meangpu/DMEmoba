using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabToNextController : MonoBehaviour {

    public InputField nextField;

    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        if (GetComponent<InputField> ().isFocused && Input.GetKeyDown (KeyCode.Tab)) {
            nextField.ActivateInputField ();
        }
    }
}