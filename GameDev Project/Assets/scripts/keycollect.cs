using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keycollect : MonoBehaviour
{

    public int keys;
    public Text score;
    void Update()
    {
        score.text = keys.ToString();
    }
}
