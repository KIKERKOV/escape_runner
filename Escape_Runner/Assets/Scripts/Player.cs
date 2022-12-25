using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public float PlayerSpeed;
    public Vector2 PlayerPosition = Vector2.zero;
    private Rigidbody2D _playerRigidBody;

    private Player_Camera _playerCamera;

    void Start()
    {
        _playerRigidBody = GetComponent<Rigidbody2D>();
        PlayerSpeed = 1f;
        _playerCamera = GameObject.Find("Player_Camera").GetComponent<Player_Camera>();
        if (_playerCamera == null){Debug.LogWarning("_playerCamera is NULL");}
        _playerCamera.transform.parent = this.transform;
    }

    private void FixedUpdate()
    {
        _playerRigidBody.velocity = PlayerPosition * PlayerSpeed;
    }

    private void PlayerMovement(InputValue value)
    {
        PlayerPosition = value.Get<Vector2>();
    }
}
