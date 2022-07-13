using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform Player;

    private float _randomTime = 0.5f;
    private float _elapsedTime = 0.0f;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            // 나눗셈보다 곱셈이 더 빠름
            Time.timeScale = 0.5f;
        }
        else
        {
            Time.timeScale = 1f;
        }

        // 0.5초 간격으로 Debug.Log() 찍어보기
        // 유니티 엔진에서 시간과 관련된 기능은 Time에 존재

        // Random을 이용해 시간 간격이 가변 되도록 작성

        _elapsedTime += Time.deltaTime;
        if (_elapsedTime >= _randomTime)
        {
            _elapsedTime = 0.0f;
            _randomTime = Random.Range(0.5f, 3.0f);
            GameObject bullet = Instantiate(BulletPrefab, transform);
            bullet.transform.LookAt(Player);
        }
    }
}
