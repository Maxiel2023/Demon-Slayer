using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inicioJugador2 : MonoBehaviour
{
    private void Start()
    {
        int IndexJugador2 = PlayerPrefs.GetInt("JugadorIndex2");
        Instantiate(GameManager2.Instance2.personajes[IndexJugador2].personajejugable2, transform.position, Quaternion.identity);                   
    }
}
