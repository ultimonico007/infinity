using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mecanica : MonoBehaviour
{
    public Rigidbody2D playerRB;
    public float salto = 5f;
    private bool tocandopiso;
    [SerializeField] Game_controler menuperder;
    // Start is called before the first frame update
    void Start()
    {
     playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& tocandopiso)
        {
            playerRB.AddForce(Vector2.up * salto, ForceMode2D.Impulse);
            tocandopiso = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    { 
        tocandopiso = true;
        if (collision.gameObject.CompareTag("enemigo"))
        {
            menuperder.activescreenLose();
            
        }
       
    }
}
