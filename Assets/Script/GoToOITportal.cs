using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToOITportal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick(){
        Application.OpenURL("https://www.portal.oit.ac.jp/CAMJWEB/top.do");
    }
}
