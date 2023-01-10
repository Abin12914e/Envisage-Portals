using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbar : MonoBehaviour
{
    public Slider slider;
    public void setmaxhealth(int health)
    {
        slider.maxValue= health;
        slider.value= health;
    }


    public void sethealth(int health)
    {
        slider.value = health;
    }


}
