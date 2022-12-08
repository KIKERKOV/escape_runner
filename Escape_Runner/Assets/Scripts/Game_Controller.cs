using UnityEngine;

public class Game_Controller : MonoBehaviour
{
    private Main_Menu_UI_Manager _main_Menu_UI_Manager;
    private Player_Controller _player_Controller;
    private Enemy_Controller _enemy_Controller;
    private Level_Design_Controller _level_Design_Controller;
    private Player _player;
    public bool SpawnNewPlayer;


    private void Start()
    {
        GameControllerWarmUp();

        _player = GameObject.Find("Player").GetComponent<Player>();
        if (_player == null)
        {
            Debug.LogWarning("Player is NULL");
        }
    }



    void Update()
    {
        SpawnPlayer();
    }

    private void SpawnPlayer()
    {
        if (SpawnNewPlayer)
        {
            _player.SpawnNewPlayer();
            SpawnNewPlayer = false;
        }
    }


    private void GameControllerWarmUp()
    {
        _main_Menu_UI_Manager = GameObject.Find("Main_Menu_UI_Manager").GetComponent<Main_Menu_UI_Manager>();
        _player_Controller = GameObject.Find("Player_Controller").GetComponent<Player_Controller>();
        _enemy_Controller = GameObject.Find("Enemy_Controller").GetComponent<Enemy_Controller>();
        _level_Design_Controller = GameObject.Find("Level_Design_Controller").GetComponent<Level_Design_Controller>();

        if (_main_Menu_UI_Manager == null)
        {
            Debug.LogWarning("Main_Menu_UI_Manager is NULL");
        }
        if (_player_Controller == null)
        {
            Debug.LogWarning("Player_Controller is NULL");
        }
        if (_enemy_Controller == null)
        {
            Debug.LogWarning("Enemy_Controller is NULL");
        }
        if (_level_Design_Controller == null)
        {
            Debug.LogWarning("Level_Design_Controller is NULL");
        }
    }











 

}
