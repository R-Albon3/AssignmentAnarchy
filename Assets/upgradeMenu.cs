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
        if (isPaused == false){
            timePassed = timePassed + Time.deltaTime;

            if (timePassed >= 30f){
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        upgradeScreen.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame()
    {
        timePassed = 0;
        upgradeScreen.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

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
        playerHealthScript.playerHearts = playerHealthScript.playerHearts - 1;
        ResumeGame();
    }
}
