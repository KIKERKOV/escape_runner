using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Main_Menu_UI_Manager : MonoBehaviour
{
    private Game_Controller _gameController;

    private void Start()
    {
        MainMenuUIManagerWarmUp();
    }


    public void StartNewGameButton()
    {
        _gameController.ChangeSCreen(2);
    }


    private void MainMenuUIManagerWarmUp()
    {
        _gameController = GameObject.Find("Game_Controller").GetComponent<Game_Controller>();

        if (_gameController == null)
        {
            Debug.LogError("Game Controller is NULL");
        }
    }    



}
