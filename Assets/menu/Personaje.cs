using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NuevoPersonaje", menuName = "Personaje")]

public class Personaje : ScriptableObject
{
    public GameObject personajejugable;
    public Sprite imagen;
    public Sprite ataque1;
    public Sprite ataque2;
    public Sprite ataque3;
    public string nombre;
    public string vida;

   
}
