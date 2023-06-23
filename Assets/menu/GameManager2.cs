using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager2 : MonoBehaviour
{
   public static GameManager2 Instance2;

   public List<Personaje2> personajes;

    private void Awake()
    {
        if(GameManager2.Instance2 == null)
        {
            GameManager2.Instance2 = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
