using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundHandler : MonoBehaviour {

    AudioSource audioSource;
    public static SoundHandler soundHandler;
    public AudioClip[] sounds;

	void Start () {
        soundHandler = GetComponent<SoundHandler>();
        audioSource = GetComponent<AudioSource>();
	}

	public void playSound(int s)
    {
        audioSource.PlayOneShot(sounds[s]);
    }
}
