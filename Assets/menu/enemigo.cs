using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemigo : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;
    int victoriaaas;
    public HealthBar healthbar;
    public Canvas canvas;
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

        gameObject.GetComponent<Animator>().SetTrigger("daño");

        if(currentHealth <= 0)
        {
            Die();
        }
        
    }

    void Die()
    {
        Debug.Log("LO MATASTE WEY");
        gameObject.GetComponent<Animator>().SetBool("muerto", true);
        this.enabled = false;
        gameObject.GetComponent<movimiento>().enabled = false;
        

    }

    public void Curar(int curacion)
    {
        currentHealth += curacion;
        healthbar.SetHealth(currentHealth);

        if ((currentHealth + curacion) > maxHealth)
        {
            currentHealth = maxHealth;
        }

    }
}
