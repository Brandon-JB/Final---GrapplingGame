using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject playButton;
    public GameObject actualPlayButton;
    public GameObject Instructions;
    public GameObject moreInstructions;
    public GameObject forRealThisTime;


    public void Start()
    {
        playButton.SetActive(true);
        actualPlayButton.SetActive(false);
        Instructions.SetActive(false);
        moreInstructions.SetActive(false);
        forRealThisTime.SetActive(false);
    }

    public void Play()
    {
        playButton.SetActive(false);
        actualPlayButton.SetActive(true);
        Instructions.SetActive(true);
    }

    public void PlayForRealThisTime()
    {
        actualPlayButton.SetActive(false);
        Instructions.SetActive(false);
        forRealThisTime.SetActive(true);
        moreInstructions.SetActive(true);
    }

    public void ActuallyPlay()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
