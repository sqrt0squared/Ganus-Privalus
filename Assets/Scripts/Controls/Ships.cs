using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ludiq;
using Bolt;

public class Ships : MonoBehaviour
{
    public Toggle toggle;

    public void onToggle()
    {
        switch (Variables.ActiveScene.Get("Selected"))
        {
            case 1:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c1-ships", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c1-ships", "false");
                }
                break;
            case 2:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c2-ships", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c2-ships", "false");
                }
                break;
            case 3:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c3-ships", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c3-ships", "false");
                }
                break;
            case 4:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c4-ships", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c4-ships", "false");
                }
                break;
            case 5:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c5-ships", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c5-ships", "false");
                }
                break;
            case 6:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c6-ships", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c6-ships", "false");
                }
                break;
            case 7:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c7-ships", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c7-ships", "false");
                }
                break;
            case 8:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c8-ships", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c8-ships", "false");
                }
                break;
            case 9:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c9-ships", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c9-ships", "false");
                }
                break;
            case 10:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c10-ships", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c10-ships", "false");
                }
                break;
            case 11:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c11-ships", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c11-ships", "false");
                }
                break;
            case 12:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c12-ships", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c12-ships", "false");
                }
                break;
        }
    }
}
