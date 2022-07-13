using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    // 1. 게임이 종료되면 GameOverUI를 보여줌
    // 2. 재시작 안내를 해준다 ~
    public TimerText Timer;
    public GameOverUI GameOverUI;
    
    private bool _isOver;

    private void Update()
    {
        // 만약 게임이 종료 되었다면
        // R키를 눌렀다면 재시작

        if (_isOver && Input.GetKeyDown(KeyCode.R))
        {
            // 씬 전환을 관리
            SceneManager.LoadScene(0);
        }
    }

    public void End()
    {
        // 타이머 종료
        Timer.IsOn = false;

        // 데이터 저장
        int savedBestTime = PlayerPrefs.GetInt("BestTime", 0);
        int bestTime = Math.Max(Timer.SurvivalTime, savedBestTime);
        PlayerPrefs.SetInt("BestTime", bestTime);

        // GameOverUI에다가 갱신
        GameOverUI.Activate(bestTime);

        // _isOver = true;
        _isOver = true;
    }
}
