using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBtnListCtr : UIWindowCtrBase
{
    Button[] btnList;
    protected override void OnTween()
    {
        Vector2 size = this.GetComponent<RectTransform>().sizeDelta;
        this.transform.localPosition = new Vector3(-size.x / 2, 0, 0);
    }
    // Start is called before the first frame update
    protected override void OnStart()
    {
        btnList = this.GetComponentsInChildren<Button>();
        for (int i = 0; i < btnList.Length; i++)
        {
            int clickIndex = i;
            Button current = btnList[i];
            current.onClick.AddListener(delegate ()
            {
                this.BtnClicked(clickIndex);
            });
            //其他三个边框不显示
            if (i >= 1)
            {
                current.transform.Find("Border").transform.gameObject.SetActive(false);
            }
        }
    }
    //参数是边框的Transfrom和下标
    private void BtnClicked(int index)
    {
        //尽量使用transfrom.Find 而少使用 gameObject.Find 因为一个是查找当前，一个是查找全局
        for (int i = 0; i < btnList.Length; i++) {
            if (i == index) {
                btnList[i].transform.Find("Border").gameObject.SetActive(true);
            }
            else
                btnList[i].transform.Find("Border").gameObject.SetActive(false);
        }
        //发数据：通知名字, 发送的对象, 下标
        NotificationCenter.GetInstance().PostNotification("HeroChange", this, index);

    }
}
