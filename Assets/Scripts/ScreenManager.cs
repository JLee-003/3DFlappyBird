using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenManager : MonoBehaviour
{
    [SerializeField] private GameObject pauseScreen;
    [SerializeField] private GameObject deathScreen;
    [SerializeField] private GameObject player;
    [SerializeField] private Animator pauseAnimator;

    private bool isPaused = false;
    bool gameOver = false;

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

    public void EndGame()
    {
        if (gameOver == false)
        {
            player.SetActive(false);
            deathScreen.SetActive(true);
            gameOver = true;
            FindObjectOfType<AudioManager>().Play("Death");
            Debug.Log("Game Over");
        }
        
    }
    public void ReplayGame()
    {
        player.SetActive(true);
        deathScreen.SetActive(false);
        gameOver = false;
        Debug.Log("Restarting Game");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
