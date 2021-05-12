using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AllKey : MonoBehaviour
{
    public InputField key1;
    public InputField key2;
    public InputField key3;

    private string _key1 = "123";
    private string _key2 = "123";
    private string _key3 = "122";


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void chech_allKeys()
    {
        if (key1.text == _key1 && key2.text == _key2 && key3.text == _key3)
        {
            SceneManager.LoadScene("Final");
        }
    }
}
