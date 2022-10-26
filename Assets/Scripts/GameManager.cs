using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOver;
    public GameObject playButton;
    public GameObject getReady;

    public BirdController birdController;

    private void Start()
    {
        StartTheGame();
    }
    public void StartTheGame()
    {
        getReady.SetActive(true);
        Time.timeScale = 0;
    }

    public void Play()
    {
        birdController.score = 0;
        birdController.scoreText.text = birdController.score.ToString();

        getReady.SetActive(false);
        playButton.SetActive(false);


        Time.timeScale = 1;
        birdController.enabled = true;
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        gameOver.SetActive(true);
        playButton.SetActive(true);
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
        getReady.SetActive(false);
        gameOver.SetActive(false);
    }
}
