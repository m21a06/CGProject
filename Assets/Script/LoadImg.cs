using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class LoadImg : MonoBehaviour
{
    //private SpriteRenderer spriteRenderer;
    private Sprite sprite;
    public Image image;

    // Start is called before the first frame update
    void Start(){
        int num = PlayerPrefs.GetInt("ClassNum");
        ImageGetter(num);
    }

    // Update is called once per frame
    void Update(){
        
    }

    public void ImageGetter(int classtime)
    {
        string room_name = LoadText.RoomGetter(classtime, 0);
        Load_Img("img/" + room_name);
    }

    public void Load_Img(string path)
    {
        sprite = Resources.Load<Sprite>(path);
        image = this.GetComponent<Image>();
        image.overrideSprite = sprite;
    }
}
