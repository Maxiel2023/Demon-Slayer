using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicaContinua : MonoBehaviour
{
    private static AudioSource audioSource;
    
   private void Awake()
    {
        if (audioSource != null)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }

    
}
