using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPAWNeNEMIGOS : MonoBehaviour
{
    public Transform rangoXIZQUIERDO;
    public Transform rangoXDERECHO;
    public Transform rangoYARRIBA;
    public Transform rangoYABAJO;

    public GameObject[]objetos;

    public float tiempoSpawn;
    public float RepeticionSpawn;



    
    void Start()
    {
        InvokeRepeating("spawnenemies", tiempoSpawn, RepeticionSpawn);
    }

    void Update()
    {
        
    }

    public void spawnenemies()
    {
        Vector3 spawnposition = new Vector3(0, 0, 0);

        spawnposition = new Vector3(Random.Range(rangoXIZQUIERDO.position.x, rangoXDERECHO.position.x), Random.Range(rangoYABAJO.position.y, rangoYARRIBA.position.y), 0);

        GameObject objeto = Instantiate(objetos[Random.Range(0, objetos.Length)], spawnposition, gameObject.transform.rotation);

    }
}
