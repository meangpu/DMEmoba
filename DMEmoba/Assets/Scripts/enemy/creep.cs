using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class creep : MonoBehaviour
{
    public int score;
    public GameObject scorePopUp;
    public scoreBoardManager Firebase;

    private void Start() 
    {
        Firebase = GameObject.Find("Firebase").GetComponent<scoreBoardManager>();
    }


    void OnDestroy()
    {
        Firebase.callAddScore(score);
        scorePopUp.transform.GetChild(0).GetComponent<TMP_Text>().text = $"+{score.ToString()}xp" ;
        Instantiate(scorePopUp, transform.position, Quaternion.identity);
    }
}
