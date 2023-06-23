using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RONDITASCHETAS : MonoBehaviour
{
    [SerializeField] private GameObject pa;
    [SerializeField] private GameObject ma;

    private void OnTriggerStay2D(Collider2D gameObject)
    {
        if(gameObject.tag == "Jugador1")       
        {
            if(gameObject.GetComponent<enemigo>().currentHealth <= 0)
            {
                gameObject.GetComponent<Animator>().SetBool("muerto", true);
                
            

                Time.timeScale = 0f;

                ma.SetActive(true);

                gameObject.GetComponent<enemigo>().enabled = false;

                gameObject.GetComponent<Enemy>().enabled = false;
            

                
            }
        }

        if(gameObject.tag == "Jugador2")
        {
            if(gameObject.GetComponent<Enemy>().vidaactual <= 0)
            {
                gameObject.GetComponent<Animator>().SetBool("MUERTO", true);
                
                Time.timeScale = 0f;
                pa.SetActive(true);

                gameObject.GetComponent<enemigo>().enabled = false;
                gameObject.GetComponent<Enemy>().enabled = false;

                
            }
        }


    }
}
