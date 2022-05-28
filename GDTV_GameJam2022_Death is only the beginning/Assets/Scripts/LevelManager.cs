using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    private void Start()
    {
        EventManager.JumpToHyperspace += LoadMainGame;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Intro");
    }

    public void LoadMainGame()
    {
        StartCoroutine(DelayMainGame());
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

    IEnumerator DelayMainGame()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Main");

    }

    private void OnDisable()
    {
        EventManager.JumpToHyperspace -= LoadMainGame;
    }
}
