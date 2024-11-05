using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upgradeMenu : MonoBehaviour
{
    //Setting various game objects to change variables within the upgrade menu
    public GameObject upgradeScreen;
    public GameObject player;
    private playerMovement playerMovementScript;
    private playerProjectiles playerProjectileScript;
    private playerHealth playerHealthScript;
    private float timePassed = 0f;
    private bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        upgradeScreen.SetActive(false);
        playerMovementScript = player.GetComponent<playerMovement>();
        playerProjectileScript = player.GetComponent<playerProjectiles>();
        playerHealthScript = player.GetComponent<playerHealth>();

    }

    
    void Update()
    {
        //Checks if the game is paused and pauses it after 30 seconds
        if (isPaused == false){
            timePassed = timePassed + Time.deltaTime;

            if (timePassed >= 30f){
                PauseGame();
            }
        }
    }
    //Pause game function to show the upgrade overlay
    public void PauseGame()
    {
        upgradeScreen.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
    //Resume game function to set time passed back to 0 and remove overlay
    public void ResumeGame()
    {
        timePassed = 0;
        upgradeScreen.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    //Each individual upgrade function which changes the respective values in each script based on which upgrade is chosen
    public void UpgradeFireRate()
    {
        playerProjectileScript.fireRate = playerProjectileScript.fireRate * 0.75f;
        ResumeGame();
    }

    public void UpgradeProjectileSpeed()
    {
        playerProjectileScript.projectileSpeed = playerProjectileScript.projectileSpeed * 1.1f;
        ResumeGame();
    }

    public void UpgradePlayerSpeed()
    {
        playerMovementScript.playerSpeed = playerMovementScript.playerSpeed * 1.1f;
        ResumeGame();
    }

    public void UpgradePlayerHearts()
    {
        playerHealthScript.playerHearts = playerHealthScript.playerHearts + 1;
        ResumeGame();
    }
}
