using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class ShowClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Text Text1, Text2,Text3, Text4, Text5;
    // Update is called once per frame
    void Update()
    {
        var tmp = LoadText.ClassGetter(1,1);
        Text1.text = tmp is null ? LoadText.ClassGetter(1,0) : LoadText.ClassGetter(1,1);

        tmp = LoadText.ClassGetter(2,1);
        Text2.text = tmp is null ? LoadText.ClassGetter(2,0) : LoadText.ClassGetter(2,1);

        tmp = LoadText.ClassGetter(3,1);
        Text3.text = tmp is null ? LoadText.ClassGetter(3,0) : LoadText.ClassGetter(3,1);

        tmp = LoadText.ClassGetter(4,1);
        Text4.text = tmp is null ? LoadText.ClassGetter(4,0) : LoadText.ClassGetter(4,1);

        tmp = LoadText.ClassGetter(5,1);
        Text5.text = tmp is null ? LoadText.ClassGetter(5,0) : LoadText.ClassGetter(5,1);
    }
}
