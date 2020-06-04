using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        UISceneMgr.Instance.OpenUIScene(UISceneType.Login);

    }
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) {
          
            //播放
            AudioManager.instance.PlayAudioSound("Help"); 
        }
        if (Input.GetKeyDown(KeyCode.D)) {
            //停止
            //AudioManager.instance.StopAudioSound();
            AudioManager.instance.PlayAudioEffect("MonkSkill");
        }
        if (Input.GetKeyDown(KeyCode.R)) {
            //静音
            AudioManager.instance.RoleSoundMute(true); 
        }
       

    }
}
