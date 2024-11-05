using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameAudio : MonoBehaviour
{
    //Audio file to manage various audio clips to play during gameplay
    public AudioSource sfxSource;
    public AudioClip walkingGrass;
    public AudioClip walkingStone;
    public AudioClip paperTear;
    public AudioClip paperWalk;
    public AudioClip shootingPencil;
    //Public function to call from other scripts
    public void PlaySFX(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
    }

}
