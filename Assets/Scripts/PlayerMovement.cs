using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float forwardSpeed;
    [SerializeField] private float jumpSpeed;

    [SerializeField] private Rigidbody rb;

    [SerializeField] private Transform mainCamera;

    private Vector2 playerInput;

    private void Awake()
    {

    }

    private void Update()
    {
        playerInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        playerInput.Normalize();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            FindObjectOfType<AudioManager>().Play("Jump");
            transform.localRotation = Quaternion.Euler(-115, 0, 180);
            rb.velocity = new Vector3(rb.velocity.x, jumpSpeed, rb.velocity.z);
        }
    }

    private void FixedUpdate()
    {
        //Vector3 moveDir = (playerInput.y * mainCamera.forward) + (playerInput.x * mainCamera.right);
        //moveDir.Normalize();
        rb.velocity = new Vector3(playerInput.x * speed, rb.velocity.y, forwardSpeed);
        transform.Rotate(-2f, 0f, 0f);
    }
}
