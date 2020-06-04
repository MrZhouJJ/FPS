using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System.Drawing;

public class UIWindowMgr : SingleTon<UIWindowMgr>
{
    //用于存储被打开窗口UI的字典(key value)
    private Dictionary<UIWindowType, GameObject> m_Dic_UIWindow = new Dictionary<UIWindowType, GameObject>();
    public void OpenUIWindow(UIWindowType windowType) {
        if (m_Dic_UIWindow.ContainsKey(windowType)) {

            m_Dic_UIWindow[windowType].SetActive(true);
            return;
        }
           
        GameObject windowUI = null;
        switch (windowType) {
            case UIWindowType.Login:
                //windowUI = ResourceMgr.Instance.Load("People", resType : ResourceType.UIWindow);
                break;
            case UIWindowType.Register:
                //windowUI = ResourceMgr.Instance.Load("renwu1", resType: ResourceType.UIWindow);
                break;
            case UIWindowType.HeroWindow:
                windowUI = ResourceMgr.Instance.Load("HeroWindow", resType: ResourceType.UIWindow);

                //windowUI.GetOrAddComponent<UIWindowCtrBase>().windowConType = UIWindowContainerType.LeftTop;
                break;
            case UIWindowType.SelectWindow:
                windowUI = ResourceMgr.Instance.Load("SelectWindow", resType: ResourceType.UIWindow);
                break;
            default:
                break;
        }
        //获取窗口UI控制器
        UIWindowCtrBase windowUICtr = windowUI.GetOrAddComponent<UIWindowCtrBase>();
        windowUICtr.windowType = windowType;
        UIWindowContainerType windowConType = windowUICtr.windowConType;
        Transform transParentWindowContainer = null;
        switch (windowConType) {
            case UIWindowContainerType.Center:
                transParentWindowContainer = UISceneMgr.Instance.currentUISceneCtr.centerContainer;
                break;
            case UIWindowContainerType.LeftBottom:
                transParentWindowContainer = UISceneMgr.Instance.currentUISceneCtr.leftBottomContainer;
                break;
            case UIWindowContainerType.LeftTop:
                transParentWindowContainer = UISceneMgr.Instance.currentUISceneCtr.leftTopContainer;
                break;
            case UIWindowContainerType.RightBottom:
                transParentWindowContainer = UISceneMgr.Instance.currentUISceneCtr.rightBottomContainer;
                break;
            case UIWindowContainerType.RightTop:
                transParentWindowContainer = UISceneMgr.Instance.currentUISceneCtr.rightTopContainer;
                break;
            default:
                break;
        }
        //设置父节点
        windowUI.transform.parent = transParentWindowContainer;
        windowUI.transform.localPosition = Vector3.zero;
        windowUI.transform.localScale = Vector3.one;
        windowUI.SetActive(true);
        m_Dic_UIWindow.Add(windowType, windowUI);
        //开始执行动画
        StartActiveUIWindow(windowUI, windowUICtr.windowShowType);
    }

    //CloseUIWindow 关闭窗口
    public void CloseUIWindow(UIWindowType windowUIType, bool delete = true) {
        if (m_Dic_UIWindow.ContainsKey(windowUIType)) {
            if (delete)
            {
                GameObject.Destroy(m_Dic_UIWindow[windowUIType]);
                m_Dic_UIWindow.Remove(windowUIType);
            }
            else
            {
                m_Dic_UIWindow[windowUIType].SetActive(false);
            }
        }
    }
    //各种窗口UI显示/关闭动画
    /// <summary>
    ///<param name="windowUI">窗口UI的预设克隆体</param> 
    ///<param name="windowShowType">类型</param> 
    ///<param name="state">显示关闭</param> 
    /// </summary>
    public void StartActiveUIWindow(GameObject windowUI, UIWindowShowAnimationType windoeShowType = UIWindowShowAnimationType.CenterToBig, bool state = true) {
        switch (windoeShowType) {
            case UIWindowShowAnimationType.Normal:
                ShowNormal(windowUI, state);
                break;
            case UIWindowShowAnimationType.CenterToBig:
                ShowCenterToBig(windowUI, state);
                break;
            case UIWindowShowAnimationType.LeftToRight:
                ShowDirection(windowUI, state, 1);
                break;
            case UIWindowShowAnimationType.RightToLeft:
                ShowDirection(windowUI, state, 2);
                break;
            case UIWindowShowAnimationType.TopToBottom:
                ShowDirection(windowUI, state, 3);
                break;
            case UIWindowShowAnimationType.BottomToTop:
                ShowDirection(windowUI, state, 4);
                break;
            default:
                break;
        }

    }
    void ShowNormal(GameObject windowUI, bool state) {
        windowUI.SetActive(true);
        
    }
    void ShowCenterToBig(GameObject windowUI, bool state)
    {
        //windowUI.SetActive(true);
        windowUI.transform.DOScale(new Vector3(2, 2, 2), 2);

    }
    void ShowDirection(GameObject windowUI, bool state, int Type) {
        windowUI.SetActive(true);
        Vector2 size = windowUI.GetComponent<RectTransform>().sizeDelta;
        switch (Type) {
            case 1:
                windowUI.transform.localPosition = Vector3.left * 300;
                windowUI.transform.DOLocalMove(Vector3.zero + new Vector3(size.x / 2, -size.y / 2, 0), 2);
                break;
            case 2:
                windowUI.transform.localPosition = Vector3.right * 300;
                windowUI.transform.DOLocalMove(Vector3.zero + new Vector3(size.x + 50 , -size.y - 50, 0), 2);
                break;
            case 3:
                windowUI.transform.localPosition = Vector3.up * 300;
                windowUI.transform.DOLocalMove(Vector3.zero, 2);
                break;
            case 4:
                windowUI.transform.localPosition = Vector3.down * 300;
                windowUI.transform.DOLocalMove(Vector3.zero, 2);
                break;
        }
    }
}
