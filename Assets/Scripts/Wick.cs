using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Wick : MonoBehaviour
{
    Text message;


    void Start()
    {

        message = GetComponent<Text>();
    }

    void Update()
    {
        
    }


    public void change_message(Button button)
    {

        message.text = "";

        string readFromFilePath = Application.streamingAssetsPath + "/MessageText/" + button.name + ".txt";
        string[] filelines = File.ReadAllLines(readFromFilePath);

        for (int i = 0; i < filelines.Length; i++)
        {
            message.text = message.text + filelines[i] + "\n";
        }

        message.fontSize = 25;

    }


}
