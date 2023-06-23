using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class barradevida2 : MonoBehaviour
{
    public Slider slider;


     public void tomarvidamaxima(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void tomarvida(int health)   
    {
        slider.value = health;
    }
}
