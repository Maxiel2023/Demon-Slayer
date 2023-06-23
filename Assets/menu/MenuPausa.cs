using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuPausa : MonoBehaviour
{

   [SerializeField] private GameObject BotonPausa;
   [SerializeField] private GameObject MenuPausaa;


   public void Pausa()
   {
    Time.timeScale = 0f;
    BotonPausa.SetActive(false);
    MenuPausaa.SetActive(true);
 
   }

   public void Reanudar()
   {
    Time.timeScale = 1f;
    BotonPausa.SetActive(true);
    MenuPausaa.SetActive(false);
   
   }

   public void Reiniciar()
   {
    Time.timeScale = 1f;
    SceneManager.LoadScene(1);
      gameObject.GetComponent<enemigo>().enabled = true;

      gameObject.GetComponent<Enemy>().enabled = true;
    
   }

   public void quitar()
   {
    Time.timeScale = 1f;
    SceneManager.LoadScene(0);
    
   }

   public void Nuevapartida()
   {
    Time.timeScale = 1f;
    SceneManager.LoadScene(4);
   }

  
    
}


