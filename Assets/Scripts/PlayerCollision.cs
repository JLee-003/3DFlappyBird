using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Wall")
        {
            FindObjectOfType<ScreenManager>().EndGame();
        }
        else if(other.gameObject.tag == "Scoring")
        {
            FindObjectOfType<ScreenManager>().IncreaseScore();
        }
    }
}
