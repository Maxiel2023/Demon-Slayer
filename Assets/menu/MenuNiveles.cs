using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuNiveles : MonoBehaviour
{
    [SerializeField] private GameObject Nivel1;
    [SerializeField] private GameObject Nivel2;

    public void Nivelll()
   {
    SceneManager.LoadScene(4);
    
   }

     public void Nivel()
   {
    SceneManager.LoadScene(5);
    
   }





}
