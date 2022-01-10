using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallClass1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        Debug.Log("CallClassPush");  // ログを出力
        callClass1();
    }

    public int callClass1(){
        return 1;
    }

}
