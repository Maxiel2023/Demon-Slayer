using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dañito : MonoBehaviour
{
    public int maxHealth = 100;
    int currentHealth;
    public HealthBar healthbar;
    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetmaxHealth(maxHealth);
    }

    // Update is called once per frame
   public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthbar.SetHealth(currentHealth);

        gameObject.GetComponent<Animator>().SetTrigger("dañoo");

        if(currentHealth <= 0)
        {
            Die();
        }
        
    }

    void Die()
    {
        Debug.Log("LO MATASTE WEY");
        gameObject.GetComponent<Animator>().SetBool("muertee", true);
        this.enabled = false;
        gameObject.GetComponent<movimiento>().enabled = false;
        

    }
}
