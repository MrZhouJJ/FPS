using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestWindow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        UISceneMgr.Instance.OpenUIScene(UISceneType.Loading);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D)) {
            //通过场景管理器获取当前运行的场景
            Destroy(UISceneMgr.Instance.currentUISceneCtr.gameObject);
        }
        
    }
}
