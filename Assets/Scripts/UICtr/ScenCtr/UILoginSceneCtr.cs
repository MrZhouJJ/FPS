using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILoginSceneCtr : UISceneCtrBase
{
    public override void OnStart()
    {
        StartCoroutine(OpenWindow());
    }
    // Start is called before the first frame update
    IEnumerator OpenWindow() {
        yield return new WaitForSeconds(0.2f);
        UIWindowMgr.Instance.OpenUIWindow(UIWindowType.Login);
        //UIWindowMgr.Instance.OpenUIWindow(UIWindowType.Header);
    }
    public override void OnUpdate()
    {
        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    UIWindowMgr.Instance.CloseUIWindow(UIWindowType.Login);
        //}
        //if (Input.GetKeyDown(KeyCode.C))
        //{
        //    UIWindowMgr.Instance.OpenUIWindow(UIWindowType.Login);
        //} 
        //if (Input.GetKeyDown(KeyCode.Q))
        //{
        //    UIWindowMgr.Instance.CloseUIWindow(UIWindowType.Login);
        //    UIWindowMgr.Instance.OpenUIWindow(UIWindowType.Register);
        //    UIWindowMgr.Instance.OpenUIWindow(UIWindowType.Header);
        //}
        
    }
}
