using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveToDemo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //this.transform.DOLocalMove(new Vector3(0, 0, 0), 2);
        this.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
