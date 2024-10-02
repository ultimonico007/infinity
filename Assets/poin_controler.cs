using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class poin_controler : MonoBehaviour
{
    public Text scoreText;
    private float score = 0;
    public float sumapuntos = 10f;
    // Start is called before the first frame update
    void Start()
    {
        score = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        score += sumapuntos * Time.deltaTime;
        scoreText.text = "score: " + Mathf.RoundToInt(score).ToString();
    }
}
