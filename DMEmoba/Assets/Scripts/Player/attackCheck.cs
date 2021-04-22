using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackCheck : MonoBehaviour
{
 
    bool attackIng = false;
    NetworkManager network;

    void Start()
    {
        this.GetComponent<Collider>().enabled = false;
        network = GameObject.Find("NetworkManager").GetComponent<NetworkManager>();
    }


    async void OnTriggerEnter(Collider col)
    {
        if (col.tag == "enemy")
        {
            Destroy(col.gameObject);
        }
        if (col.tag == "player")
        {
            col.GetComponent<PlayerHp>().TakeDamage(col.GetComponent<PlayerHp>().damageTake);
            await network.room.Send("health", new {name = col.name, hp = col.GetComponent<PlayerHp>().currentHealth});
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
