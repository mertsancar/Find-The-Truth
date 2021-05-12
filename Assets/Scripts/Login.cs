using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Login : MonoBehaviour
{
    public InputField username_input;
    public InputField password_input;

    private GameObject welcome;
    private GameObject popup;

    public string username;
    public string password;
      
    void Start()
    {
        welcome = GameObject.FindGameObjectWithTag("welcome");
        popup = GameObject.FindGameObjectWithTag("popup");

        welcome.gameObject.SetActive(false);
        popup.gameObject.SetActive(false);

    }


    void Update()
    {

    }

    public void check_username_password()
    {
        if (username_input.text == username && password_input.text == password)
        {

            Debug.Log("Correct");
            welcome.SetActive(true);
            gameObject.SetActive(false);

        }
        else
        {
            Debug.Log("False");
            popup.SetActive(true);
        }
    }



}
