using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UIWindowType
{ 
    /// 登录窗口
    Login,
    /// 注册窗口
    Register,
    /// 头像窗口
    Header,
    /// 功能窗口
    Function,
    /// 技能窗口
    Skill,

    SelectWindow,

    HeroWindow
}
public enum UIWindowContainerType 
{
    /// 居中
    Center,
    /// 左上
    LeftTop,
    /// 左下
    LeftBottom,
    /// 右上
    RightTop,
    /// 右下
    RightBottom,
    /// 右中
    RightCenter
    
}

// 显示窗口UI时播放的动画
public enum UIWindowShowAnimationType
{
    /// 正常显示
    Normal,
    /// 从中间向两边放大
    CenterToBig,
    /// 从左到右
    LeftToRight,
    /// 从右到左
    RightToLeft,
    /// 从上到下
    TopToBottom,
    /// 从下到上
    BottomToTop
}


/// 资源类型(枚举)
public enum ResourceType
{
    ///场景UI类型
    UIScene = 0,
    ///窗口UI类型
    UIWindow,
    //人物选择

}

///场景UI类型
public enum UISceneType 
{
    Login,
    Loading,
    Battle,
}

public enum AudioType { 
    BgAudio,
    EffAudio,
    souAudio
}



