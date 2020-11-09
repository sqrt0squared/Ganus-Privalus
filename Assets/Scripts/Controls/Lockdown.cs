using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ludiq;
using Bolt;

public class Lockdown : MonoBehaviour
{
    public Toggle toggle;

    public void onToggle()
    {
        switch (Variables.ActiveScene.Get("Selected"))
        {
            case 1:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c1-lockdown", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c1-lockdown", "false");
                }
                break;
            case 2:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c2-lockdown", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c2-lockdown", "false");
                }
                break;
            case 3:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c3-lockdown", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c3-lockdown", "false");
                }
                break;
            case 4:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c4-lockdown", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c4-lockdown", "false");
                }
                break;
            case 5:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c5-lockdown", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c5-lockdown", "false");
                }
                break;
            case 6:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c6-lockdown", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c6-lockdown", "false");
                }
                break;
            case 7:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c7-lockdown", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c7-lockdown", "false");
                }
                break;
            case 8:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c8-lockdown", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c8-lockdown", "false");
                }
                break;
            case 9:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c9-lockdown", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c9-lockdown", "false");
                }
                break;
            case 10:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c10-lockdown", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c10-lockdown", "false");
                }
                break;
            case 11:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c11-lockdown", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c11-lockdown", "false");
                }
                break;
            case 12:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c12-lockdown", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c12-lockdown", "false");
                }
                break;
        }
    }
}
