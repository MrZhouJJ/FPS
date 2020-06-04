using System.Collections;
using System.Text;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Rendering;

public class ResourceMgr : SingleTon<ResourceMgr>
{
    public void Unload(GameObject obj) {
        //卸载未使用的资源
        Resources.UnloadUnusedAssets();
        ////卸载指定的资源
        //Resources.UnloadAsset(obj);
    }
    public GameObject Load(string path, ResourceType resType = ResourceType.UIScene) {
        StringBuilder stringBuilder = new StringBuilder();
        switch (resType) {
            case ResourceType.UIScene: stringBuilder.Append("UI/UIScence/");
                break;
            case ResourceType.UIWindow: stringBuilder.Append("UI/UIWindow/");
                break;
            default:
                break;
        }
        //追加文件路径
        stringBuilder.Append(path);
        GameObject uiRes = Resources.Load(stringBuilder.ToString()) as GameObject;
        //初始化到界面
        return GameObject.Instantiate(uiRes);
    }

    public AudioClip[] LoadAudio(AudioType audioType = AudioType.BgAudio) {
        StringBuilder sb = new StringBuilder();
        AudioClip[] clips = null;
        switch (audioType) {
            case AudioType.BgAudio:
                sb.Append("AudioClips/Sounds");
                break;
            case AudioType.EffAudio:
                sb.Append("AudioClips/RoleEffectClip");
                break;
            case AudioType.souAudio:
                sb.Append("AudioClips/RoleSoundClip");
                break;
        }
        clips = Resources.LoadAll<AudioClip>(sb.ToString());
        return clips;
    }
}
