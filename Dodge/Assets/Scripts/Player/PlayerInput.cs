using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    // 프로퍼티로 bool 타입의 Up, Down, Left, Right 만들기
    public bool Up { get; private set; }
    public bool Down { get; private set; }
    public bool Left { get; private set; }
    public bool Right { get; private set; }
    
    void Update()
    {   
        // 이전 값을 날리고, 기본 값으로 초기화
        Up = Down = Left = Right = false;

        // 현재 프레임의 입력 값을 저장
        Up = Input.GetKey(KeyCode.W);
        Down = Input.GetKey(KeyCode.S); 
        Right = Input.GetKey(KeyCode.A);
        Left = Input.GetKey(KeyCode.D);
    }
}
