using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnClick()
    {
        Debug.Log("push");  // ログを出力
        int num = 1;

        switch (transform.name) {
            case "Button1":
                num = 1;
                break;
            case "Button2":
                num = 2;
                break;
            case "Button3":
                num = 3;
                break;
            case "Button4":
                num = 4;
                break;
            case "Button5":
                num = 5;
                break;
            default:
                break;
        }
        PlayerPrefs.SetInt("ClassNum", num);
        PlayerPrefs.Save();
        ChangeScene(num);
        
    }

    void ChangeScene(int num)
    {
        if(LoadText.ClassGetter(num,1) != null)
            SceneManager.LoadScene("classroomLocation");
        if(LoadText.ClassGetter(num,0) != null)
            SceneManager.LoadScene("classroomLocation");
    }
}
