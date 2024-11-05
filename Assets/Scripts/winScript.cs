using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winScript : MonoBehaviour
{
   //Identical to the lossMenu, allows the player to return to main menu from the victory screen
   public void backToMenu()
   {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
   }
}
