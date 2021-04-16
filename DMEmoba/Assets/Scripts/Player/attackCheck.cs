using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackCheck : MonoBehaviour
{

    bool attackIng = false;

    void Start()
    {
        this.GetComponent<Collider>().enabled = false;
    }


    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "enemy")
        {
            Debug.Log(col);
            Destroy(col.gameObject);
        }
    }

    void checkCollision()
    {
        StartCoroutine("setAttack");
    }

    IEnumerator setAttack()
    {
        this.GetComponent<Collider>().enabled = true;
        attackIng = true;
        yield return new WaitForSeconds(.4f);
        attackIng = false;
        this.GetComponent<Collider>().enabled = false;

    }
}