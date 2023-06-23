using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuSeleccionPersonaje2 : MonoBehaviour
{
    private int index;
    [SerializeField] private Image imagen2;
    [SerializeField] private TextMeshProUGUI nombre2;
    [SerializeField] private TextMeshProUGUI vida2;
    [SerializeField] private Image ATAQUE1;
    [SerializeField] private Image ATAQUE2;
    [SerializeField] private Image ATAQUE3;
    
   
    private GameManager2 gameManager2;

    private void Start()
    {
        
        gameManager2 = GameManager2.Instance2;

        index = PlayerPrefs.GetInt("JugadorIndex2");

        if(index > gameManager2.personajes.Count - 1)
        {
            index = 0;
        }

        CambiarPantalla();
    }

    private void CambiarPantalla()
    {
        PlayerPrefs.SetInt("JugadorIndex2", index);
        imagen2.sprite = gameManager2.personajes[index].imagen2;
        nombre2.text = gameManager2.personajes[index].nombre2;
        ATAQUE1.sprite = gameManager2.personajes[index].ATAQUE1;
        ATAQUE2.sprite = gameManager2.personajes[index].ATAQUE2;
        ATAQUE3.sprite = gameManager2.personajes[index].ATAQUE3;
        vida2.text = gameManager2.personajes[index].vida2;
    }

    public void SiguientePersonaje()
    {
        if(index == gameManager2.personajes.Count - 1)
        {
            index = 0;
        }
        else
        {
            index +=1;
        }
        CambiarPantalla();
    }

    public void AnteriorPersonaje()
    {
        if(index == 0)
        {
            index = gameManager2.personajes.Count - 1;
        }
        else
        {
            index -=1;
        }
        CambiarPantalla();
    }

    public void SiguienteMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }
}
