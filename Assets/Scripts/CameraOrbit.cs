using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOrbit : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Vector3 offset;
    [SerializeField] private float orbitRadius;

    [SerializeField] private float mouseSensitivity = 1f;
    [SerializeField] private float maxHorizontalAngle = 90f;
    [SerializeField] private float maxVerticalAngle = 75f;

    private Vector2 mouseInput;
    private float angle;

    private float rotX, rotY;
    private void Awake()
    {
        
    }

    private void Update()
    {
        mouseInput = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
    }

    private void LateUpdate()
    {
        //angle += mouseInput.x * mouseSensitivity * Time.deltaTime;
        //transform.position = new Vector3(rotX, 0, -rotZ) + player.position;
        //transform.rotation = Quaternion.LookRotation(player.position - transform.position);
        //angle = Mathf.Clamp(angle, Mathf.Deg2Rad * -maxHorizontalAngle, Mathf.Deg2Rad * maxHorizontalAngle);

        rotX += Input.GetAxis("Mouse Y") * mouseSensitivity;
        rotY += Input.GetAxis("Mouse X") * mouseSensitivity;
        rotX = Mathf.Clamp(rotX, -maxVerticalAngle, maxVerticalAngle);
        rotY = Mathf.Clamp(rotY, -maxHorizontalAngle, maxHorizontalAngle);
        this.transform.rotation = Quaternion.Euler(-rotX, rotY, 0);
        this.transform.position = player.position - (this.transform.forward * orbitRadius);
    }
}
