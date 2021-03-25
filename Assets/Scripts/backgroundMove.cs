using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundMove : MonoBehaviour
{
   [SerializeField]//바깥에서 변경 가능하지만 해킹으로 수정 불가
    private float speed = 0.5f;//프라이베잇으로 하면 바깥에서 번경 불가

    private MeshRenderer meshRenderer = null;// null = 아무것도 없다
    private Vector2 offset = Vector2.zero;//이차원

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>(); // 시작하자마자 컴포넌트를 가져온다 

    }


    void Update()
    {
        if (meshRenderer == null) return; //에러 방지 (null)
        offset.y += speed * Time.deltaTime;//1초당 얼마를 움직임
        meshRenderer.material.SetTextureOffset("_MainTex", offset);// 택스쳐를 바꿈 (vector)



    }
}
