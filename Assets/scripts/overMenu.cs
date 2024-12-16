using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameoverMenu : MonoBehaviour
{
    public void Menu()
    {
        SceneManager.LoadScene("menuScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }


}
