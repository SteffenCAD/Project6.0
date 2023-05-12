using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceenManager : MonoBehaviour
{
    public BW_test BW_worker;

    public void changeToSceen(int sceneID)
    {
        BW_worker.start();
        //SceneManager.LoadScene(sceneID);
        //SceneManager.LoadScene("OtherSceneName", LoadSceneMode.Additive);
    }
}
