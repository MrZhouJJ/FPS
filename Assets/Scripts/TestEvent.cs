using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class TestEvent : MonoBehaviour, IDragHandler
{
    public float Speed = 0.01f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    public void OnDrag(PointerEventData eventData)
    {
        //var rt = gameObject.GetComponent<RectTransform>();
        //Vector3 globalMousePos;
        //if (RectTransformUtility.ScreenPointToWorldPointInRectangle(rt, eventData.position, eventData.pressEventCamera, out globalMousePos))
        //{
        //    //rt.position = globalMousePos;
        //    transform.Rotate(new Vector3(0, globalMousePos.y, 0) * Speed, Space.World);
        //}
        this.transform.localEulerAngles += new Vector3(0, -eventData.delta.x, 0);
       
    }
   
}
