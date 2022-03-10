using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class musicScript : MonoBehaviour
{
    private AudioSource aS;
    public AudioMixer mixer;

    void Start()
    {
        int numMusic = FindObjectsOfType<musicScript>().Length;
        if (numMusic != 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
}