using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallGenerator : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnRate = 1f;
    public float minY = -4f;
    public float maxY = 4f;
    public float minX = -4f;
    public float maxX = 4f;

    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn()
    {
        GameObject pipes = Instantiate(pipePrefab, transform.position, Quaternion.identity);
        pipes.transform.position += new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), 0);
    }
}
