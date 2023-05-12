using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UpdateText : MonoBehaviour
{

    public TMPro.TMP_Text text;
    //public TextMesh text;
    public DATA data;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = data.received;
    }
}
