using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class gameover : MonoBehaviour
{
    public Text score1;
    void Update()
    {
        score1.text = playermovements.keys.ToString();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
    public void quitgame()
    {
        Application.Quit();


    }
    public void playagain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);


    }

}
