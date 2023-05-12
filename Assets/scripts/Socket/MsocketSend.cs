using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MsocketSend : MonoBehaviour
{
    public Msocket socket;

    public void send(string data)
    {
        socket.sendString(data);
    }
}
