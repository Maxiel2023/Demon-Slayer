using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lava : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
   {
    if(other.gameObject.CompareTag("Jugador1"))
    {
        other.gameObject.GetComponent<enemigo>().TakeDamage(20);
      
    }

    if(other.gameObject.CompareTag("Jugador2"))
    {
        other.gameObject.GetComponent<Enemy>().TakeDamage(20);
        
    }
   }
}
