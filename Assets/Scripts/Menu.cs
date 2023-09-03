using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadScene(0);
    }

    // Update is called once per frame
    public void ExitGame()
    {
        Application.Quit();
        Run.countCoin = 0;
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(3);
        Run.countCoin = 0;
    }
}
