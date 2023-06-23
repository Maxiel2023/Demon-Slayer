using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BarraDeVida : MonoBehaviour
{
    public Slider slider;

    private void Start()
    {
        slider = GetComponent<Slider>();
    }


    public void cambiarvidamaxima(float vidamaxima)
    {
        slider.maxValue = vidamaxima;
    }

    public void cambiarvidaactual(float cantidadvida)
    {
        slider.value = cantidadvida;
    }

    public void inicializarbarradevida(float cantidadvida)
    {
        
        cambiarvidamaxima(cantidadvida);
        cambiarvidaactual(cantidadvida);
    }
}
