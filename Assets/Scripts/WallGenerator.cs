using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallGenerator : MonoBehaviour
{
    public GameObject topWallPrefab;
    public GameObject bottomWallPrefab;
    public GameObject sideWallPrefab;
    public float wallSpawnInterval = 2f;
    public float minHoleHeight = 2f;
    public float maxHoleHeight = 4f;

    private void Start()
    {
        InvokeRepeating("SpawnWalls", 0f, wallSpawnInterval);
    }

    private void SpawnWalls()
    {
        float holeHeight = Random.Range(minHoleHeight, maxHoleHeight);

        // Instantiate top wall
        GameObject topWall = Instantiate(topWallPrefab, new Vector3(transform.position.x, holeHeight / 2, 0), Quaternion.identity);

        // Instantiate bottom wall
        GameObject bottomWall = Instantiate(bottomWallPrefab, new Vector3(transform.position.x, -holeHeight / 2, 0), Quaternion.identity);

        // Randomize side wall length
        float sideWallLength = Random.Range(2f, 5f);

        // Instantiate side walls
        GameObject leftSideWall = Instantiate(sideWallPrefab, new Vector3(transform.position.x - sideWallLength / 2, 0, holeHeight / 2), Quaternion.Euler(0, 90, 0));
        GameObject rightSideWall = Instantiate(sideWallPrefab, new Vector3(transform.position.x + sideWallLength / 2, 0, holeHeight / 2), Quaternion.Euler(0, -90, 0));
    }
}
