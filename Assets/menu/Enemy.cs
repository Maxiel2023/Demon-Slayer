using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int maximavida;
    public int vidaactual;
    public barradevida2 barradevida2;
    public Animator animator;
    public Canvas canvas;
    int victorias;
   
     public void Start()
    {
        vidaactual = maximavida;
        barradevida2.tomarvidamaxima(maximavida);

    }

    // Update is called once per frame
   public void TakeDamage(int damage)
    {
        vidaactual -= damage;
        barradevida2.tomarvida(vidaactual);

       animator.SetTrigger("DAÑADO");

        if(vidaactual <= 0)
        {
            
            Die();
        }
        
    }

    void Die()
    {
        Debug.Log("LO MATASTE WEY");

        animator.SetBool("MUERTO", true);

        this.enabled = false;
        gameObject.GetComponent<movimiento2>().enabled = false;
        gameObject.GetComponent<Enemy>().enabled = false;
        
    }

    public void Curar(int curacion)
    {
        vidaactual += curacion;
        barradevida2.tomarvida(vidaactual);
        if ((vidaactual + curacion) > maximavida)
        {
            vidaactual = maximavida;
        }

        
    }

    
}
