using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;
    private Vector2 targetPosition = Vector2.zero;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButton(0))//0 = 좌클릭 1 = 우클릭 
        {
            targetPosition = 
                Camera.main.ScreenToWorldPoint(Input.mousePosition);// 메인 카메라의 기준을 바꿔준다
            transform.localPosition = 
                Vector2.MoveTowards(transform.localPosition,
                targetPosition, speed * Time.deltaTime);

        }
    }
}
