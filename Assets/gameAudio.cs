using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameAudio : MonoBehaviour
{

    public AudioSource sfxSource;

    public AudioClip walkingGrass;
    public AudioClip walkingStone;
    public AudioClip paperTear;
    public AudioClip paperWalk;
    public AudioClip shootingPencil;

    public void PlaySFX(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
    }

}
