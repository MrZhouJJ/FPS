using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UILoginWindowCtr : UIWindowCtrBase
{
    //重写父类的函数, 实现一些按钮的逻辑
    public Button button1;
    public Button button2;
    public Button button3;

    protected override void OnStart()
    {
    //    Button_one();
    //    Button_two();
    //    Button_three();
    }

    // Start is called before the first frame update
    public void Button_one() {
        button1.onClick.AddListener(delegate () {
            UIWindowMgr.Instance.OpenUIWindow(UIWindowType.Header);
            UIWindowMgr.Instance.CloseUIWindow(UIWindowType.Register); 
            UIWindowMgr.Instance.CloseUIWindow(UIWindowType.Skill);
        }); 
    }
    public void Button_two() {
        button2.onClick.AddListener(delegate () {
            UIWindowMgr.Instance.OpenUIWindow(UIWindowType.Register);
            UIWindowMgr.Instance.CloseUIWindow(UIWindowType.Header);
            UIWindowMgr.Instance.CloseUIWindow(UIWindowType.Skill);
        }); 
    }
    public void Button_three() {
        button3.onClick.AddListener(delegate () {
            UIWindowMgr.Instance.OpenUIWindow(UIWindowType.Skill);
            UIWindowMgr.Instance.CloseUIWindow(UIWindowType.Register);
            UIWindowMgr.Instance.CloseUIWindow(UIWindowType.Header);
        }); 
    }
    
}
