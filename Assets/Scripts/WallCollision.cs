using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WallCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        FindObjectOfType<AudioManager>().Play("Death");
        Debug.Log("Collided");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
