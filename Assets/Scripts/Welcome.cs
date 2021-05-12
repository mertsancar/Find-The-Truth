using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Welcome : MonoBehaviour
{
    private AudioSource Opening;
    public AudioClip OpeningSound;


    void Start()
    {
        Opening = GetComponent<AudioSource>();
        Opening.PlayOneShot(OpeningSound);

        StartCoroutine(Wait());

    }

    void Update()
    {

    }



    IEnumerator Wait()
    {
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene("Desktop");
    }


}