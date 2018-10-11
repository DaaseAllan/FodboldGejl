using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundHandler : MonoBehaviour {

    AudioSource audioSource;
    public static SoundHandler soundHandler;
    public AudioClip[] sounds;

    private static bool created = false;

    void Awake()
    {
        if (created)
        {
            Destroy(this.gameObject);
        }

        if (!created)
        {
            DontDestroyOnLoad(this.gameObject);
            created = true;
            //Debug.Log("Awake: " + this.gameObject);
        }

    }

    void Start()
    {
        soundHandler = GetComponent<SoundHandler>();
        audioSource = GetComponent<AudioSource>();

        audioSource.Play();
    }

    public void playSound(int s)
    {
        audioSource.PlayOneShot(sounds[s]);
    }
}
