using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour
{

    public int playerHearts;
    public Image[] currentHearts;

    // Update is called once per frame
    void Update()
    {
        if(playerHearts == 0){
            Application.Quit();
            UnityEditor.EditorApplication.isPlaying = false;
        }
        for(int i = 0; i < 8; i++){
            if(i < playerHearts){
                currentHearts[i].enabled = true;
            } else {
                currentHearts[i].enabled = false;
            }
        }
    }
}
