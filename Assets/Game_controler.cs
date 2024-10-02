using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Game_controler : MonoBehaviour
{
    public Text puntajeFinal;
    public Score highscore;
    [SerializeField] GameObject Lose;
    // Start is called before the first frame update
    void Start()
    {
        Lose.SetActive(false);
    }
    public void activescreenLose()
    {
        Lose.SetActive(true);
        Time.timeScale = 0f;
    }
    public void restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
