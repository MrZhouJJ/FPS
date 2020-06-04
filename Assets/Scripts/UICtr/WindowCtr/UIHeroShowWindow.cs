using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHeroShowWindow : UIWindowCtrBase
{
    public Image image;
    public Sprite[] allSprite;
    // Start is called before the first frame update
    protected override void OnStart()
    {
        //添加观察者以及对应的处理函数
        NotificationCenter.GetInstance().AddObserver("HeroChange", IndexChanged);
    }
    public void IndexChanged(Notification not) {
        //获取发送的详细数据
        Debug.Log(not.data.ToString());
        image.sprite = allSprite[(int)not.data];
    }
}
