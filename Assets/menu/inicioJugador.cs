using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inicioJugador : MonoBehaviour
{
    private void Start()
    {
        int IndexJugador = PlayerPrefs.GetInt("JugadorIndex");
        Instantiate(GameManager.Instance.personajes[IndexJugador].personajejugable, transform.position, Quaternion.identity);                   
    }
}
