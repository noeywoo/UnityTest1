using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0f; //회전 속도

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //마우스 왼쪽 버튼을 클릭하면 회전
        if (Input.GetMouseButtonDown(0))
        {
            rotSpeed = -10f;

        }
        transform.Rotate(0, 0, rotSpeed);
        rotSpeed *= 0.999f; //감속
        if (rotSpeed > -0.001f) rotSpeed = 0f; //속도가 일정 속도 이하이면 멈춤
    }
        
}
