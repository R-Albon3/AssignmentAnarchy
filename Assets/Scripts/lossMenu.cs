using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lossMenu : MonoBehaviour
{
   //Function that takes the loss scene back to the main menu 
   public void backToMenu()
   {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
   }
}
