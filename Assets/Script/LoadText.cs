using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class LoadText : MonoBehaviour
{

    public static string[] textMessage; //テキストの加工前の一行を入れる変数
    public static string[,] textWords; //テキストの複数列を入れる2次元は配列 

    public static string[,] className;
    public static string[,] roomName;

    public static int rowLength; //テキスト内の行数を取得する変数
    public static int columnLength; //テキスト内の列数を取得する変数

    private void Start() {

    }
    
    public static void Load_Text(string msg){

        TextAsset textasset = new TextAsset(); //テキストファイルのデータを取得するインスタンスを作成
        textasset = Resources.Load(msg, typeof(TextAsset) )as TextAsset; //Resourcesフォルダから対象テキストを取得
        string TextLines = textasset.text; //テキスト全体をstring型で入れる変数を用意して入れる

        //Splitで一行づつを代入した1次配列を作成
        textMessage = TextLines.Split('\n'); //

        //行数と列数を取得
        columnLength = 64;//textMessage[0].Split('\t').Length;
        rowLength = textMessage.Length;

        //2次配列を定義
        className = new string[rowLength+3, columnLength+1];
        roomName = new string[rowLength+3, columnLength+1];
        textWords = new string[rowLength+3, columnLength+1];
        
        int t1 = 0, t2 = 0, t3 = 0, t4 = 0, t5 = 0;
        for(int i = 0; i < rowLength; i++) {

            string[] tempWords = textMessage[i].Split(' ', '\t'); //textMessageをカンマごとに分けたものを一時的にtempWordsに代入
            int time  = 0;
            int.TryParse(tempWords[0], out time);

            switch (time) {
                case 1:
                    className[time,t1] = tempWords[1];
                    roomName[time,t1++] = tempWords[2];
                    break;
                case 2:
                    className[time,t2] = tempWords[1];
                    roomName[time,t2++] = tempWords[2];
                    break;
                case 3:
                    className[time,t3] = tempWords[1];
                    roomName[time,t3++] = tempWords[2];
                    break;
                case 4:
                    className[time,t4] = tempWords[1];
                    roomName[time,t4++] = tempWords[2];
                    break;
                case 5:
                    className[time,t5] = tempWords[1];
                    roomName[time,t5++] = tempWords[2];
                    break;
                default:
                    break;
            }
        }
    }

    public static string ClassGetter(int num, int class_name){
        return className[num, class_name];
    }

    public static string RoomGetter(int num, int class_name){
        return roomName[num, class_name];
    }
}
