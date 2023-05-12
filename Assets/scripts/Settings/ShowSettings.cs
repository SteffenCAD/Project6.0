using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowSettings : MonoBehaviour
{
    public GameObject MenueMain;
    public GameObject MenueSettings;


    public void show()
    {
        if(MenueMain.activeInHierarchy)
        {
            MenueMain.SetActive(false);
            MenueSettings.SetActive(true);
        }
        else
        {
            MenueMain.SetActive(true);
            MenueSettings.SetActive(false);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        MenueMain.SetActive(true);
        MenueSettings.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
