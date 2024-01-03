using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed = 5f;


    private void Update()
    {
        transform.position += Vector3.back * speed * Time.deltaTime;

        if (transform.position.z < -50)
        {
            Destroy(gameObject);
        }
    }
}
