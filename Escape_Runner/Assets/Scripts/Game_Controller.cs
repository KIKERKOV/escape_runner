using UnityEngine;

public class Game_Controller : MonoBehaviour
{
    private Main_Menu_UI_Manager _main_Menu_UI_Manager;
    private bool PlayerIsSpawned = false;
    [SerializeField] private GameObject _playerPrefab;
    [SerializeField] private GameObject _playerContainer;

    private void Start()
    {
        GameControllerWarmUp();
    }

    public void SpawnNewPlayer()
    {
        GameObject newPlayer = Instantiate(_playerPrefab, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
        newPlayer.transform.parent = _playerContainer.transform;
        newPlayer.name = "Player";
    }


    private void FixedUpdate()
    {        
        if (Input.GetKeyDown(KeyCode.Space) && !PlayerIsSpawned)
        {
            SpawnNewPlayer();
            PlayerIsSpawned = true;
        }
    }

    private void GameControllerWarmUp()
    {        
        _main_Menu_UI_Manager = GameObject.Find("Main_Menu_UI_Manager").GetComponent<Main_Menu_UI_Manager>();

        if (_main_Menu_UI_Manager == null)
        {
            Debug.LogWarning("Main_Menu_UI_Manager is NULL");
        }
    }











 

}
