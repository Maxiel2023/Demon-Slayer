using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class Rondas : MonoBehaviour
{
    [SerializeField] private GameObject pa;
    [SerializeField] private GameObject ma;
    

   
    void Mensaje()
    {
        if(gameObject.GetComponent<enemigo>().currentHealth <= 0)
            {
                Time.timeScale = 0f;
                ma.SetActive(true);
            }

        if(gameObject.GetComponent<Enemy>().vidaactual <= 0)
            {
                Time.timeScale = 0f;
                pa.SetActive(true);
            }
    }
}
