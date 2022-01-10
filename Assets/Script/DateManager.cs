using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
 
/// <summary>
/// 
/// Unity 2018.2.10f1
/// 
/// </summary>
 
public class DateManager : MonoBehaviour
{

    // 日本語の曜日を取得
    string dayOfWeekJa = "";
    // Use this for initialization
    private void Start()
    {
        string youbi = GetDayOfTheWeek("20220401");
 
        Debug.Log(youbi);
    }
 
    // 日付から曜日を取得する
    private string GetDayOfTheWeek(string date)
    {
        // DateTimeを生成
        DateTime dateTime = DateTime.ParseExact(date, "yyyyMMdd", null);
 
 
        switch (dateTime.DayOfWeek)
        {
            case DayOfWeek.Sunday:
                dayOfWeekJa = "休み";
                break;
            case DayOfWeek.Monday:
                dayOfWeekJa = "月曜日の時間割";
                break;
            case DayOfWeek.Tuesday:
                dayOfWeekJa = "火曜日の時間割";
                break;
            case DayOfWeek.Wednesday:
                dayOfWeekJa = "水曜日の時間割";
                break;
            case DayOfWeek.Thursday:
                dayOfWeekJa = "木曜日の時間割";
                break;
            case DayOfWeek.Friday:
                dayOfWeekJa = "金曜日の時間割";
                break;
            case DayOfWeek.Saturday:
                dayOfWeekJa = "土曜日の時間割";
                break;
        }
 
        // 曜日 (英語)
        Debug.Log(dateTime.ToString("dddd"));
        Debug.Log(dateTime.ToString("ddd"));
 
        // 戻り値: 曜日 (日本語)
        return dayOfWeekJa;
    }

    public Text text;

    // Update is called once per frame
	void Update () {

		if(Input.GetMouseButtonDown(0)){

			text.text = dayOfWeekJa;
		
	}
}

}
