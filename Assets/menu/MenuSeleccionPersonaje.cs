using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuSeleccionPersonaje : MonoBehaviour
{
    private int index;
    [SerializeField] private Image imagen;
    [SerializeField] private TextMeshProUGUI nombre;
    [SerializeField] private TextMeshProUGUI vida;
    [SerializeField] private Image ataque1;
    [SerializeField] private Image ataque2;
    [SerializeField] private Image ataque3;


    private GameManager gameManager;

    private void Start()
    {
        
        gameManager = GameManager.Instance;

        index = PlayerPrefs.GetInt("JugadorIndex");

        if(index > gameManager.personajes.Count - 1)
        {
            index = 0;
        }

        CambiarPantalla();
    }

    private void CambiarPantalla()
    {
        PlayerPrefs.SetInt("JugadorIndex", index);
        imagen.sprite = gameManager.personajes[index].imagen;
        nombre.text = gameManager.personajes[index].nombre;
        vida.text = gameManager.personajes[index].vida;
        ataque1.sprite = gameManager.personajes[index].ataque1;
        ataque2.sprite = gameManager.personajes[index].ataque2;
        ataque3.sprite = gameManager.personajes[index].ataque3;
    }

    public void SiguientePersonaje()
    {
        if(index == gameManager.personajes.Count - 1)
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
            index = gameManager.personajes.Count - 1;
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
