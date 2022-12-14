using UnityEngine;

public class Game_Controller : MonoBehaviour
{
    private Main_Menu_UI_Manager _main_Menu_UI_Manager;
    private Player_Controller _player_Controller;

    private void Start()
    {
        GameControllerWarmUp();
    }


    private void FixedUpdate()
    {
        
    }

    private void SpawnPlayer(bool SpawnNewPlayer)
    {
        if (SpawnNewPlayer == true)
        {
            _player_Controller.SpawnNewPlayer();
            SpawnNewPlayer = false;
        }
    }


    private void GameControllerWarmUp()
    {
        
        _main_Menu_UI_Manager = GameObject.Find("Main_Menu_UI_Manager").GetComponent<Main_Menu_UI_Manager>();

        if (_main_Menu_UI_Manager == null)
        {
            Debug.LogWarning("Main_Menu_UI_Manager is NULL");
        }
        if (_player_Controller == null)
        {
            Debug.LogWarning("Player is NULL");
        }

    }











 

}
