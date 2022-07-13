using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerText : MonoBehaviour
{
    public int SurvivalTime { get; private set; } 
    public bool IsOn { get; set; }

    private TextMeshProUGUI _ui;
    private float _elapsedTime;

    void Start()
    {
        _ui = GetComponent<TextMeshProUGUI>();
        _ui.text = $"시간 : {SurvivalTime}초";

        IsOn = true;
    }

    void Update()
    {
        if (IsOn)
        {
            // 1초에 한 번씩만 업데이트 되도록        
            _elapsedTime += Time.deltaTime;
            if (_elapsedTime >= 1f)
            {
                ++SurvivalTime;
                _elapsedTime -= 1f;
                _ui.text = $"시간 : {SurvivalTime}초";

            }
        }
    }
}