using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject _playerContainer;

    public void SpawnNewPlayer()
    {
        GameObject newPlayer = Instantiate(Player, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
        newPlayer.transform.parent = _playerContainer.transform;
        newPlayer.AddComponent<Player>();
    }

}
