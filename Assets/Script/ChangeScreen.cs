using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        // Start is called before the first frame update
    public void OnClick()
    {
        Debug.Log("push");  // ログを出力
        ChangeScene();
        
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("main");
    }
}
