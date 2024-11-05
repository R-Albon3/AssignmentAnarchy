using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerHealth : MonoBehaviour
{
    //Setting player hearts and an image array of the hearts
    public int playerHearts;
    public Image[] currentHearts;

    void Update()
    {
        //If the player loses all their hearts the game ends
        if(playerHearts == 0){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        //Displays i amount of hearts depending on how many remaining hearts the player has
        for(int i = 0; i < 8; i++){
            if(i < playerHearts){
                currentHearts[i].enabled = true;
            } else {
                currentHearts[i].enabled = false;
            }
        }
    }
}
