using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIHeroScenCtr : UISceneCtrBase
{
    public  override void OnStart() {
        StartCoroutine(OpenWindow());
    }
    IEnumerator OpenWindow()
    {

        yield return new WaitForSeconds(0.2f);
        UIWindowMgr.Instance.OpenUIWindow(UIWindowType.SelectWindow);
        UIWindowMgr.Instance.OpenUIWindow(UIWindowType.HeroWindow);
    }
}
