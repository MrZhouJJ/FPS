using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UIIconWindowCtrl : UIWindowCtrBase
{
    protected override void OnStart(){}
    
    // Start is called before the first frame update
    protected override void OnTween() {
        Sequence mySequence = DOTween.Sequence();
        
        this.transform.localPosition = Vector3.left * 300;
        mySequence.Append(this.transform.DOLocalMove(Vector3.zero, 2));
        //mySequence.AppendInterval(0.5f);
        //mySequence.Append(transform.DOLocalRotate(new Vector3(0, 0, -360), 2f));
        mySequence.AppendInterval(0.5f);
        //mySequence.Append(transform.DOShakePosition(2, 10, 10, 50, true));
        mySequence.Append(this.transform.DOShakeScale(1f));
        mySequence.Append(this.transform.DORotate(new Vector3(0, 0, -720), 2));
        //或者用：
        //SetRelative 是设置相对
        //mySequence.Append(this.transform.DORotate(new Vector3(0, 0, 720), 2f).SetRelative(true));
    }
    protected override void OnUpdate(){}
}
