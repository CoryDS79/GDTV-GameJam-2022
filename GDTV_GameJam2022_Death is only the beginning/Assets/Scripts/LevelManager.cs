using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
  
    public void QuitGame()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void GameOver()
    {
        StartCoroutine(DelayGameOver());
    }

    IEnumerator DelayGameOver()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Game Over");

    }
}