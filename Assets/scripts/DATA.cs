using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using UnityEngine;

public class DATA : MonoBehaviour
{
    #region dataStuctureStuff
    [Category("DataStructureSuff")]
    [Browsable(false)]
    public bool enablePropertyToSend { get; set; } = true;
    #endregion

    public string received = "empty";

    private string value_value 



    #region PropertyChangedEVentHandler
    public event PropertyChangedEventHandler PropertyChanged;
    private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    #endregion

    #region PropertyToSend
    public event PropertyChangedEventHandler PropertyToSend;
    private void NotifyPropertyToSend([CallerMemberName] string propertyName = "")
    {
        if (enablePropertyToSend)
        {
            PropertyToSend?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public void SocketReceived(string data)
    {
        //disable sending if data is received from node red
        this.enablePropertyToSend = false;
        //this.fromJSON(data);
        this.received = data;
        this.enablePropertyToSend = true;
    }

    #endregion
}
