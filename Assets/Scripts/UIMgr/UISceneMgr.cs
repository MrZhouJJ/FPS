using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISceneMgr : SingleTon<UISceneMgr>
{
    //每一个场景都存在一个UISceneCtrBase子类的脚本, 表示当前场景UI控制器
    public UISceneCtrBase currentUISceneCtr;
    public void OpenUIScene(UISceneType sceneType) {
        GameObject sceneUI = null;
        switch (sceneType) {
            case UISceneType.Login:
                //sceneUI = ResourceMgr.Instance.Load("DScene", resType:ResourceType.UIScene);
                break;
            case UISceneType.Loading:
                sceneUI = ResourceMgr.Instance.Load("HeroScene", resType: ResourceType.UIScene);
                sceneUI.GetComponent<Canvas>().renderMode = RenderMode.ScreenSpaceCamera;
                sceneUI.GetComponent<Canvas>().worldCamera = Camera.main;
                break;
            case UISceneType.Battle:
                break;
            default:
                break;
        }
        currentUISceneCtr = sceneUI.GetComponent<UISceneCtrBase>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
