using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSwap : MonoBehaviour
{
    public void MainGame() {

        SceneManager.LoadScene("MainScene");

    }

    public void DeathScreen() {

        SceneManager.LoadScene("DeathScreen");

    }

    public void Credits() {

        SceneManager.LoadScene("Credits");

    }

    public void Controls()
    {

        SceneManager.LoadScene("Controls");

    }



    public void Title()
    {

        SceneManager.LoadScene("TitleScreen");

    }

    public void Exit() {

        Application.Quit();

    }
}
