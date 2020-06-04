using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//模板方法设计模式: 父类定义骨架, 子类具体执行
public class UISceneCtrBase : MonoBehaviour
{
    /// 挂点 中间
    public Transform centerContainer;
    /// 挂点 左上
    public Transform leftTopContainer;
    /// 挂点 左下
    public Transform leftBottomContainer;
    /// 挂点 右上
    public Transform rightTopContainer;
    /// 挂点 右下
    public Transform rightBottomContainer;

    // Start is called before the first frame update
    void Start()
    {
        OnStart();
    }

    // Update is called once per frame
    void Update()
    {
        OnUpdate();
    }
    public virtual void OnStart() { }
    public virtual void OnUpdate() { }
}
