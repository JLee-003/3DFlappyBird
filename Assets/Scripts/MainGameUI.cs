using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainGameUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private ScreenManager screenManager;

    private void Update()
    {   
        scoreText.text = "Score:" + screenManager.score.ToString();
    }
}
