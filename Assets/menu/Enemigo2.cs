using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo2 : MonoBehaviour
{
   public int maximavida = 100;
    int vidaactual;
    public barradevida2 barradevida2;
    void Start()
    {
        vidaactual = maximavida;
        barradevida2.tomarvidamaxima(maximavida);

    }

    // Update is called once per frame
   public void TakeDamage(int damage)
    {
        vidaactual -= damage;
        barradevida2.tomarvida(vidaactual);

        gameObject.GetComponent<Animator>().SetTrigger("daño");

        if(vidaactual <= 0)
        {
            Die();
        }
        
    }

    void Die()
    {
        Debug.Log("LO MATASTE WEY");
        gameObject.GetComponent<Animator>().SetBool("muerto", true);
        this.enabled = false;
        gameObject.GetComponent<movimiento2>().enabled = false;
        

    }
}
