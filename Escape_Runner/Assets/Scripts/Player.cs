using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    float horizontal;
    float vertical;
    public float runSpeed = 20.0f;

    private Player_Camera _playerCamera;
    private Rigidbody2D _rigidBody;


    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        _playerCamera = GameObject.Find("Player_Camera").GetComponent<Player_Camera>();
        _playerCamera.transform.parent = transform.parent;
        if (_playerCamera == null)
        {
            Debug.LogWarning("Player_Camera is NULL");
        }
    }

    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        if (horizontal != 0)
        {
            Debug.Log("Horizontal input");
        }
        if (vertical != 0)
        {
            Debug.Log("Vertical input");
        }
    }
}
