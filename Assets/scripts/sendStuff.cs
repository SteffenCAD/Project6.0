using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sendStuff : MonoBehaviour
{
    public BW_test bwtest;

    public void sendString(string data)
    {
        bwtest.sendString(data);
    }
}
