using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class punto : MonoBehaviour
{
    public Transform personaje;
    public Transform puntodeataque;

    void Start()
    {
      
      gameObject.GetComponent<Rigidbody>().AddForce(new Vector2(10f * Time.deltaTime, 0));
    }
   
}
