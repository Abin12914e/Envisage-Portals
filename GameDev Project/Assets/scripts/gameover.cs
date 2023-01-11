using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class gameover : MonoBehaviour
{
    public Text score1;
    void Update()
    {
        score1.text = playermovements.keys.ToString();
    }
    public void quitgame()
    {
        Application.Quit();
    }
}
