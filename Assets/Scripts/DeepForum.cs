using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class DeepForum : MonoBehaviour
{
    public Text topicName;
    public Text topicWritter;
    public Text text;

    public Text TitleTopic;
    public Text TitleUserName;




    void Start()
    {
        gameObject.SetActive(false);
    }


    void Update()
    {
        
    }

    public void Topic(int topicID)
    {
        gameObject.SetActive(true);

        string readFromFilePath = Application.streamingAssetsPath + "/DeepForum/topic"+  topicID + ".txt";
        string[] filelines = File.ReadAllLines(readFromFilePath);

        topicWritter.text = "Yazar: "+ TitleUserName.text;
        topicName.text = TitleTopic.text;
        for (int i = 0; i < filelines.Length; i++)
        {
                text.text = text.text + filelines[i] + "\n";
        }
      
    }


}
