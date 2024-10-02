using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnenemies : MonoBehaviour
{
    public GameObject[] ArregloDeobstaculos;
    public Vector2 spawnpos;
    public float tiempodearranque;
    public float repeticion;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnobstacle", tiempodearranque, repeticion);
    }
    void spawnobstacle()
    {
        int indiceAleatorio = Random.Range(0, ArregloDeobstaculos.Length);
        GameObject obstaculoaleatorio = ArregloDeobstaculos[indiceAleatorio];
        Vector3 spawnPosition = new Vector3(spawnpos.x, spawnpos.y, -1);
        Instantiate(obstaculoaleatorio, spawnpos, obstaculoaleatorio.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
