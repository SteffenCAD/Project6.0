using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSaveSettings : MonoBehaviour
{
    public Settings settings;

    private ARconfig config = new ARconfig();
    public void save()
    {
        config.save(settings);
    }

    public void load()
    {
        settings = (Settings)config.load(typeof(Settings));
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
