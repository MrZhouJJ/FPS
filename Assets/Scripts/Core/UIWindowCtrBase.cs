using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIWindowCtrBase : MonoBehaviour
{
    /// 窗口UI类型数组, 存储的是即将打开的窗口
    public List<UIWindowType> windowTypeArray = new List<UIWindowType>();
    /// 窗口UI的挂点类型, 默认是居中的
    public UIWindowContainerType windowConType = UIWindowContainerType.Center;
    /// 显示/关闭窗口UI的动画, 默认是正常显示/关闭
    public UIWindowShowAnimationType windowShowType = UIWindowShowAnimationType.Normal;
    /// 显示/关闭动画的持续时间
    public float duration = 1f;
    /// 动画播放的曲线
    public AnimationCurve windowUIShowAnimationCurve = new AnimationCurve();
    /// 窗口UI的类型, 默认是登录窗口
    [HideInInspector]
    public UIWindowType windowType = UIWindowType.Login;
    // Start is called before the first frame update
    void Start()
    {
        OnTween();//初始化动画
        OnStart();//初始化其他
    }

    // Update is called once per frame
    void Update()
    {
        OnUpdate();
    }
    private void OnDestroy()
    {
        BeforeOnDestory();
    }
    protected virtual void OnStart() { }
    protected virtual void OnTween() { }
    protected virtual void OnUpdate() { }
    protected virtual void BeforeOnDestory() { }
}
