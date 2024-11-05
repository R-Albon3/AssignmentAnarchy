using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bossHealthBar : MonoBehaviour
{
    //Grabbing the UI healthBar element
    public Slider healthBar;
    //Public function to call from the bossScript to lower its health bar value
    public void UpdateHealthBar()
    {
        //Bosses health is 5 and each shot deals 1 damage
        healthBar.value = healthBar.value - 0.2f;
    }
    
}
