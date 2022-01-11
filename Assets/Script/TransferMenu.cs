using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransferMenu : MonoBehaviour
{
    public void OnClick()
    {
        ChangeScene();   
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("main");
    }
}
