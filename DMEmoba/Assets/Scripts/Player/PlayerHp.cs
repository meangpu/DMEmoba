using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHp : MonoBehaviour
{

    public int maxHealth = 10;
    public int damageTake = 5;
    public int currentHealth;
    public HPBar healthBar;

    private void Awake()
    {
        currentHealth = maxHealth;
        healthBar.SetHealth(currentHealth);
    }

    public void TakeDamage(int damage)
    {
        if (currentHealth - damage > 0)
        {
            currentHealth -= damage;
            healthBar.SetHealth(currentHealth);
        }
        else
        {
            currentHealth = 0;
            healthBar.SetHealth(currentHealth);
            Debug.Log("Player DIE!!");
            // Destroy(gameObject);
        }

    }

    public void ChangeHealth(int hp)
    {
        currentHealth = hp;
        healthBar.SetHealth(currentHealth);
    }

}