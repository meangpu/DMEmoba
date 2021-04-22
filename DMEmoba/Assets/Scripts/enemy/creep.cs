using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class creep : MonoBehaviour
{
    public int score;
    public GameObject scorePopUp;
    public FirebaseManager Firebase;

    private void Start() 
    {
        Firebase = GameObject.Find("Firebase").GetComponent<FirebaseManager>();
    }


    void OnDestroy()
    {
        Firebase.AddXP(score);
        scorePopUp.transform.GetChild(0).GetComponent<TMP_Text>().text = $"+{score.ToString()}xp" ;
        Debug.Log(scorePopUp.transform.GetChild(0).gameObject);
        Instantiate(scorePopUp, transform.position, Quaternion.identity);
    }
}
