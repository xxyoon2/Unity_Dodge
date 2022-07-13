using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed = 0.01f;
    void Start()
    {
        Destroy(gameObject, 5f);
    }

    void Update()
    {
        transform.Translate(0f, 0f, Speed);
    }
}

//범위, 범위에 타겟이 없으면 뱅글뱅글 돌기만 하고
// 타겟이 있을 시, 플레이어를 향해 총알을 갈김