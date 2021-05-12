using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Password : MonoBehaviour
{
    public InputField givenPassword;
    public string password;

    private AudioSource error;
    public AudioClip errorSound;

    void Start()
    {
        gameObject.SetActive(true);
        error = GetComponent<AudioSource>();
    }


    void Update()
    {
        
    }

    public void check_password()
    {
        if (givenPassword.text == password)
        {
            gameObject.SetActive(false);
        }
        else
        {
            error.PlayOneShot(errorSound);
        }
    }
}
