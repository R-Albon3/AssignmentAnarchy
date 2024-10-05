using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{

    //Creating a transform variable to assign the player object to
    public Transform playerCharacter;

    void Update()
    {
        //Movement to center the camera on the player and follow until the bounds are reached
        //at which point the camera ceases moving in that direction until the character moves
        //away from the bound
        transform.position = new Vector3(Mathf.Clamp(playerCharacter.position.x, -11.2f, 11.2f), 
        Mathf.Clamp(playerCharacter.position.y, -13.70f, 14.7f),
        transform.position.z);
    }
}
