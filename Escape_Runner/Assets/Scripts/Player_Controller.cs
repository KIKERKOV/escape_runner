using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    [SerializeField] private GameObject PlayerPrefab;
    [SerializeField] private GameObject _playerContainer;
    public Vector2 PlayerPosition;


    public void SpawnNewPlayer()
    {
        GameObject newPlayer = Instantiate(PlayerPrefab, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
        newPlayer.transform.parent = _playerContainer.transform;
        newPlayer.name = "Player";
        newPlayer.AddComponent<Player>();
    }

}
