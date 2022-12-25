using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public UnityEvent OnPlayerInteract;
    [SerializeField] private GameObject _playerPrefab;
    [SerializeField] private GameObject _playerContainer;
    public Vector2 PlayerPosition;
    public float PlayerSpeed;
    private Player_Camera _playerCamera;

    void Start()
    {
        PlayerSpeed = 0.15f;
        _playerCamera = GameObject.Find("Player_Camera").GetComponent<Player_Camera>();
        if (_playerCamera == null){Debug.LogWarning("_playerCamera is NULL");}
        _playerCamera.transform.parent = this.transform;
    }

    private void FixedUpdate()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector2 inputVector = new Vector2(horizontal, vertical);

        if (horizontal != 0)
        {
            transform.Translate(inputVector * PlayerSpeed);

            Debug.Log("Horizontal input");
        }
        if (vertical != 0)
        {
            transform.Translate(inputVector * PlayerSpeed);
            Debug.Log("Vertical input");
        }
    }
}
