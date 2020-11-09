using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public void onClick()
    {
        if(PlayerPrefs.GetString("saved") == "" || PlayerPrefs.GetString("saved") == "false" || PlayerPrefs.GetString("saved") == null)
        {
            PlayerPrefs.SetString("play", "new");
            SceneManager.LoadScene("Game");
        }
        else if(PlayerPrefs.GetString("saved") == "true")
        {
            SceneManager.LoadScene("GameSettings");
        }
    }
}
