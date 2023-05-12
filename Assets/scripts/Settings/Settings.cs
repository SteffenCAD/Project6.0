using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    #region PROGRAM
    public string IP_SENDING { get; set; } = "127.0.0.1";
    public string IP_RECEIVING { get; set; } = "127.0.0.1";
    public int PORT_SENDING { get; set; } = 60100;
    public int PORT_RECEIVING { get; set; } = 60101;
    #endregion
}
