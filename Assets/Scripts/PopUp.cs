using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp : MonoBehaviour
{
    private AudioSource Opening;
    public AudioClip OpeningSound;

    private bool isPlayed = true;

    void Start()
    {
        Opening = GetComponent<AudioSource>();
    }


    void Update()
    {
        if (isPlayed)
        {
            playSound();
            isPlayed = false;
        }
    }


    void playSound()
    {
        if (gameObject.activeSelf)
        {
            Opening.PlayOneShot(OpeningSound);
        }
    }


    public void close_popup()
    {
        isPlayed = true;
        gameObject.SetActive(false);
    }


}
