using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Hint : MonoBehaviour
{

    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void show_hint()
    {
        gameObject.SetActive(true);

    }
}
