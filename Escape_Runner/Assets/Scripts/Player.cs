using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool PlayerIsSpawned;
    float horizontal;
    float vertical;
    public float runSpeed = 20.0f;

    private Player_Camera _playerCamera;
    private Rigidbody2D _rigidBody;


    [SerializeField] private GameObject PlayerPrefab;
    [SerializeField] private GameObject _playerContainer;
    public Vector2 PlayerPosition;

    private void Start()
    {
        NoClonesAllowed();
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
        PlayerMovement();
    }

    private void PlayerMovement()
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

    public void SpawnNewPlayer()
    {
        GameObject newPlayer = Instantiate(PlayerPrefab, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
        newPlayer.transform.parent = _playerContainer.transform;
        newPlayer.name = "Player";
        newPlayer.AddComponent<Player>();
    }

    private void NoClonesAllowed()
    {
        if (PlayerIsSpawned)
        {
            return;
        }
    }

}
