using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class AudioManager : MonoBehaviour
{
    /// <summary>
    /// 单例模式
    /// </summary>
    public static AudioManager instance;

    /// <summary>
    /// 将声音放入字典中，方便管理
    private Dictionary<string, AudioClip> _RoleSoundClipDic = new Dictionary<string, AudioClip>();
    private Dictionary<string, AudioClip> _RoleEffectClipDic1 = new Dictionary<string, AudioClip>();
    private Dictionary<string, AudioClip> _RoleEffectClipDic2 = new Dictionary<string, AudioClip>();
    private AudioSource[] audioSources;

    private AudioSource roleSources;
    private AudioSource roleEffect1;
    private AudioSource roleEffect2;

    void Awake()
    {
        instance = this;
        LoadRoleSoundClip();//加载
        LoadRoleEffectClip();
        //获取音频播放组件
        audioSources = GetComponents<AudioSource>();
        roleSources = audioSources[0];
        roleEffect1 = audioSources[1];
        roleEffect2 = audioSources[2];
    }

    //播放音效
    public void PlayAudioEffect(string audioEffectName) {
        if (_RoleEffectClipDic1.ContainsKey(audioEffectName))
        {
            roleEffect1.clip = _RoleEffectClipDic1[audioEffectName];
            roleEffect1.Play();
        }
       
    }


    //播放语音
    public void PlayAudioSound(string audioSoundName)
    {
        if (_RoleSoundClipDic.ContainsKey(audioSoundName))
        {
            roleSources.clip = _RoleSoundClipDic[audioSoundName];
            roleSources.Play();
        }
    }

    /// <summary>
    /// 停止音效播放
    /// </summary>
    public void StopAudioEffect()
    {
        if (roleSources != null)
        {
            roleSources.Stop();
        }
    }

    /// <summary>
    /// 停止语音播放
    /// </summary>
    public void StopAudioSound()
    {
        if (roleSources != null)
        {
            Debug.Log("语音播放停止！！");
            roleSources.Stop();
        }
    }

    //语音是否静音
    public void RoleSoundMute(bool isMute)
    {
        if (roleSources != null)
        {
            roleSources.mute = isMute;
        }
    }

    /// <summary>
    /// 加载角色语音片段
    /// </summary>
    public void LoadRoleSoundClip()
    {
        AudioClip[] roleSoundAudioArray = ResourceMgr.Instance.LoadAudio(AudioType.souAudio);

        for (int i = 0; i < roleSoundAudioArray.Length; i++)
        {
            _RoleSoundClipDic.Add(roleSoundAudioArray[i].name, roleSoundAudioArray[i]);
        }
    }

    /// <summary>
    /// 加载角色音效片段
    /// </summary>
    public void LoadRoleEffectClip()
    {
        //本地加载 
        AudioClip[] roleEffectAudioArray = ResourceMgr.Instance.LoadAudio(AudioType.EffAudio);

        //存放到字典                
        for (int i = 0; i < roleEffectAudioArray.Length; i++)
        {
            _RoleEffectClipDic1.Add(roleEffectAudioArray[i].name, roleEffectAudioArray[i]);
        }
    }
}
