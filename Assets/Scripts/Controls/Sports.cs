using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ludiq;
using Bolt;

public class Sports : MonoBehaviour
{
    public Toggle toggle;

    public void onToggle()
    {
        switch (Variables.ActiveScene.Get("Selected"))
        {
            case 1:
                if(toggle.isOn)
                {
                    PlayerPrefs.SetString("c1-sports", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c1-sports", "false");
                }
                break;
            case 2:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c2-sports", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c2-sports", "false");
                }
                break;
            case 3:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c3-sports", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c3-sports", "false");
                }
                break;
            case 4:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c4-sports", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c4-sports", "false");
                }
                break;
            case 5:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c5-sports", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c5-sports", "false");
                }
                break;
            case 6:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c6-sports", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c6-sports", "false");
                }
                break;
            case 7:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c7-sports", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c7-sports", "false");
                }
                break;
            case 8:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c8-sports", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c8-sports", "false");
                }
                break;
            case 9:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c9-sports", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c9-sports", "false");
                }
                break;
            case 10:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c10-sports", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c10-sports", "false");
                }
                break;
            case 11:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c11-sports", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c11-sports", "false");
                }
                break;
            case 12:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c12-sports", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c12-sports", "false");
                }
                break;
        }
    }
}
