using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.Net.Sockets;
using System.ComponentModel;
using System.Threading;


public class BW_test : MonoBehaviour
{
    #region vairables

    private  BackgroundWorker worker = new BackgroundWorker();
    private  BackgroundWorker workerSending = new BackgroundWorker();


    private  List<string> DataToSend = new List<string>();
    #endregion

    public void init(string IP_SEND, string IP_RECEIVE, int PORT_SEND = 0, int PORT_RECEIVE = 0)
    {

    }
    public void start()
    {
        if (worker.IsBusy != true)
        {
            worker.WorkerSupportsCancellation = true;
            worker.DoWork += Worker_Receiving;
            worker.RunWorkerAsync();

            workerSending.WorkerSupportsCancellation = true;
            workerSending.DoWork += WorkerSending_DoWork;
            workerSending.RunWorkerAsync();
            Debug.Log("socket server started");
        }
    }
    public void stop()
    {
        if (worker.IsBusy)
        {
            worker.CancelAsync();
            workerSending.CancelAsync();
            Debug.Log("socket server stopped");
        }
    }
    private void Worker_Receiving(object sender, DoWorkEventArgs e)
    {
        while (!worker.CancellationPending )
        {
            Thread.Sleep(1000);
            Debug.Log("Worker_receiving");
        }
    }
    private  void WorkerSending_DoWork(object sender, DoWorkEventArgs e)
    {
        while (!workerSending.CancellationPending)
        {
            Thread.Sleep(1000);
            Debug.Log("Worker_sending");
        }
    }
    public  void sendString(string data)
    {
        DataToSend.Add(data);
        Debug.Log("DataToSend: " + data);
    }

    public bool IsRunning
    {
        get
        {
            return worker.IsBusy;
        }
    }

    #region OnSocketReceived event      

    public delegate void SockedReceivedEventHandler(string data);

    public event SockedReceivedEventHandler SocketReceived;

    protected virtual void OnSocketReceived(string data)
    {
        SocketReceived?.Invoke(data);
    }
    #endregion

    #region PropertyToSend event
    /// <summary>
    /// this event is for receiving data
    /// </summary>
    public void PropertyToSend(object sender, PropertyChangedEventArgs e)
    {
        if (sender.GetType().GetProperty(e.PropertyName).GetValue(sender, null).ToString() == "False")
        {
            DataToSend.Add('{' + e.PropertyName.ToString() + "," + "false" + ',' + sender.GetType().GetProperty(e.PropertyName).PropertyType.Name + '}');
        }
        else
        {
            DataToSend.Add('{' + e.PropertyName.ToString() + "," + sender.GetType().GetProperty(e.PropertyName).GetValue(sender, null).ToString() + ',' + sender.GetType().GetProperty(e.PropertyName).PropertyType.Name + '}');

        }
    }
    #endregion
}
