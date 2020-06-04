using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notification 
{
    public string name;      //通知的名字
    public Component sender; //注册的用户组件：谁发的通知
    public object data;      //附加发送的信息：传递的参数
    public Notification(string name, Component sender) {
        this.name = name;
        this.sender = sender;
        this.data = null;
    }
    public Notification(string name, Component sender, object data) {
        this.name = name;
        this.sender = sender;
        this.data = data;
    }
}
