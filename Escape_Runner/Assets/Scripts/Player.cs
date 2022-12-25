using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    private bool _playerIsSpawned;
    float horizontal;
    float vertical;
    public UnityEvent OnPlayerInteract;
    private Rigidbody2D _rigidBody;
    [SerializeField] private GameObject _playerPrefab;
    [SerializeField] private GameObject _playerContainer;
    public Vector2 PlayerPosition;
    public float PlayerSpeed;


    // Start is called before the first frame update
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        PlayerSpeed = 0.15f;
    }

    private void FixedUpdate()
    {
        
        PlayerMovement();

    }

    private void PlayerMovement()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 inputVector = new Vector3(horizontal, 0, vertical);
        inputVector.Normalize();

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
