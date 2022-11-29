using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    [SerializeField] private GameObject Player;


    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Player, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
        AddComponents();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void AddComponents()
    {
        Player.AddComponent<Rigidbody2D>();
    }

    private void PlayerSetup()
    {
        
    }

    
}
