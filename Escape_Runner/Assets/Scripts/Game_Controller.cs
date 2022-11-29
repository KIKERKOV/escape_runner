using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Controller : MonoBehaviour
{
    public void ChangeSCreen(int _changeScreen)
    {
        switch (_changeScreen)
        {
            case 1:
                MainMenu();
                break;
            case 2:
                StartNewGame();
                break;
            case 3:
                ContinueGame();
                break;
            case 4:
                break;
            default:
                break;
        }
    }


    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void StartNewGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ContinueGame()
    {
        SceneManager.LoadScene(2);
    }

}
