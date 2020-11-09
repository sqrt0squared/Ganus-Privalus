﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSettings : MonoBehaviour
{
    public void NewGame()
    {
        PlayerPrefs.SetString("play", "new");
        SceneManager.LoadScene("Game");
    }

    public void Continue()
    {
        PlayerPrefs.SetString("play", "continue");
        SceneManager.LoadScene("Game");
    }
}
