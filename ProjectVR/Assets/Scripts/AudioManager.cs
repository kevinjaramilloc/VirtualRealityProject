using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource ambientAudio;
    public AudioSource animalSounds;
	
	void Start ()
    {
        ambientAudio.Play();
        animalSounds.Play();
	}
}
