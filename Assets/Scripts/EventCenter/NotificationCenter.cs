using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;


public class NotificationCenter : MonoBehaviour
{
    private static NotificationCenter center = null;
    public static NotificationCenter GetInstance() {
        if (center == null) {
            GameObject g = new GameObject("NotificationCenter");    //若示例为空则创建一个物体并把该实体附加
            center = g.AddComponent<NotificationCenter>();
        }
        return center;
    }
    //字典选用Action<Notification>类型，实现了对各种参数的转换，缺陷是只能传一个参数，可以自己船舰泛型委托
    private Dictionary<string, Action<Notification>> notificationDic;
    void Awake()
    {
        notificationDic = new Dictionary<string, Action<Notification>>();//初始化字典变量
    }
    #region 观察者
    ///添加观察者方法
    public void AddObserver(string name, Action<Notification> action) {
        if (notificationDic.ContainsKey(name))
        {
            notificationDic[name] += action;//若字典存在该key则将对应的委托添加传来的委托: 委托链
        }
        else {
            notificationDic.Add(name, action);//不存在则添加该key和传来的委托
        }
    }
    ///移除观察者的方法
    public void RemoveObserver(string name, Action<Notification> action) {
        if (notificationDic.ContainsKey(name))
        {
            notificationDic[name] -= action;
            if (notificationDic[name] == null) {
                notificationDic.Remove(name);
            }
        }
    }
    #endregion

    #region 触发通知
    //作为外部调用
    public void PostNotification(string name, Component sender) {
        PostNotification(name, sender, null);
    }
    //作为外部调用
    public void PostNotification(string name, Component sender, object data) {
        PostNotification(new Notification(name, sender, data));
    }
    //内部实际的调用
    private void PostNotification(Notification notification) {
        if (notificationDic.ContainsKey(notification.name)) {
            notificationDic[notification.name](notification);
        }
    }
    #endregion
}
