using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ludiq;
using Bolt;

public class LimitedPeople : MonoBehaviour
{
    public Toggle toggle;

    public void onToggle()
    {
        switch (Variables.ActiveScene.Get("Selected"))  
        {
            case 1:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c1-limited", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c1-limited", "false");
                }
                break;
            case 2:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c2-limited", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c2-limited", "false");
                }
                break;
            case 3:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c3-limited", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c3-limited", "false");
                }
                break;
            case 4:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c4-limited", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c4-limited", "false");
                }
                break;
            case 5:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c5-limited", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c5-limited", "false");
                }
                break;
            case 6:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c6-limited", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c6-limited", "false");
                }
                break;
            case 7:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c7-limited", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c7-limited", "false");
                }
                break;
            case 8:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c8-limited", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c8-limited", "false");
                }
                break;
            case 9:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c9-limited", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c9-limited", "false");
                }
                break;
            case 10:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c10-limited", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c10-limited", "false");
                }
                break;
            case 11:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c11-limited", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c11-limited", "false");
                }
                break;
            case 12:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c12-limited", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c12-limited", "false");
                }
                break;
        }
    }
}
