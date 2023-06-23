using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuego : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
   {
    if(other.CompareTag("Jugador1"))
    {
        other.GetComponent<enemigo>().TakeDamage(20);
        Destroy(gameObject);
    }

    if(other.CompareTag("Jugador2"))
    {
        other.GetComponent<Enemy>().TakeDamage(20);
        Destroy(gameObject);
    }
   }
}
