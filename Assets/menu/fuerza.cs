using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuerza : MonoBehaviour
{
         [SerializeField] private AudioClip recolectarSonido;

    private void OnCollisionEnter2D(Collision2D other)   
    {
    if(other.gameObject.CompareTag("Jugador1"))
    {
        ControladorSonido.Instance.EjecutarSonido(recolectarSonido);
        other.gameObject.GetComponent<movimiento>().Fortaleza(20);
        Destroy(gameObject);
    }

    if(other.gameObject.CompareTag("Jugador2"))
    {
        ControladorSonido.Instance.EjecutarSonido(recolectarSonido);
        other.gameObject.GetComponent<movimiento2>().Fortaleza(20);
        Destroy(gameObject);
    }
   }
}
