using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MsocketStartStop : MonoBehaviour
{
    public Msocket socket;
    public DATA data;
    // Start is called before the first frame update
    void Start()
    {
        socket.init("192.168.227.170", "192.168.227.75", 60100, 60101);
        //socket.init("127.0.0.1", "127.0.0.1", 60100,60101);

         socket.SocketReceived += data.SocketReceived;
        data.PropertyToSend += socket.PropertyToSend;


        socket.start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnApplicationQuit()
    {
        socket.stop();
    }
}
