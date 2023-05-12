using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class BtnChangeColor : MonoBehaviour
{
    public GameObject newButton;
    private System.Random rnd = new System.Random();
    private bool toggle = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeColor()
    {       
        if (toggle)
        {
            toggle = false;
            newButton.GetComponent<Image>().color = new Color(255, 0, 0);
        }
        else
        {
            newButton.GetComponent<Image>().color = new Color(0, 255, 0);
        }

    }

}
