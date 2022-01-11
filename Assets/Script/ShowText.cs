using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowText : MonoBehaviour
{

    public GameObject Text_obj = null; // Textオブジェクト
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // オブジェクトからTextコンポーネントを取得
        Text text_obj =  Text_obj.GetComponent<Text>();
        // テキストの表示を入れ替える
        text_obj.text = "工大マップ";
    }
}
