using UnityEngine;

public class Game_Controller : MonoBehaviour
{
    private Main_Menu_UI_Manager _main_Menu_UI_Manager;
    [SerializeField] private GameObject _playerPrefab;
    [SerializeField] private GameObject _playerContainer;

    private void Start()
    {
        GameControllerWarmUp();
        SpawnNewPlayer(_playerPrefab);
    }

    public void SpawnNewPlayer(GameObject newPlayer)
    {
        newPlayer = Instantiate(newPlayer, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
        newPlayer.transform.parent = _playerContainer.transform;
        newPlayer.name = "Player";
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
