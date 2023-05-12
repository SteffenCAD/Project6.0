using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BW_statstop : MonoBehaviour
{
    public BW_test bwtest;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Application start " + Time.time + " seconds");
        bwtest.start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnApplicationQuit()
    {
        Debug.Log("Application ending after " + Time.time + " seconds");
        bwtest.stop();
    }
}
