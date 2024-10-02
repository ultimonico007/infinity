using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov_enemy : MonoBehaviour
{
    public float speed = 4f;
    public float tiempovivo = 0f;
    public float tiempodevidamax = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(speed * (Time.deltaTime), 0, 0);
        tiempovivo += Time.deltaTime;
        if (tiempovivo >= tiempodevidamax)
        {
            Destroy(this.gameObject);
        }
    }
}
