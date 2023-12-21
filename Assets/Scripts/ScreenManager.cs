using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenManager : MonoBehaviour
{
    [SerializeField] private GameObject pauseScreen;
    [SerializeField] private Animator pauseAnimator;

    private bool isPaused = false;
    public bool dead = false;

    private void Awake()
    {
        pauseScreen.SetActive(isPaused);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
            pauseScreen.SetActive(isPaused);
            if (isPaused)
            {
                Time.timeScale = 0;
                pauseAnimator.SetTrigger("FadeIn");

            }
            else
            {
                Time.timeScale = 1f;
            }
        }
    }

    public void Unpuase()
    {
        isPaused = false;
        Time.timeScale = 1f;
        pauseScreen.SetActive(false);
    }

    public void ReplayGame()
    {

    }
}
