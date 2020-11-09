using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ludiq;
using Bolt;

public class Shops : MonoBehaviour
{
    public Toggle toggle;

    public void onToggle()
    {
        switch (Variables.ActiveScene.Get("Selected"))
        {
            case 1:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c1-shops", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c1-shops", "false");
                }
                break;
            case 2:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c2-shops", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c2-shops", "false");
                }
                break;
            case 3:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c3-shops", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c3-shops", "false");
                }
                break;
            case 4:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c4-shops", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c4-shops", "false");
                }
                break;
            case 5:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c5-shops", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c5-shops", "false");
                }
                break;
            case 6:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c6-shops", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c6-shops", "false");
                }
                break;
            case 7:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c7-shops", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c7-shops", "false");
                }
                break;
            case 8:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c8-shops", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c8-shops", "false");
                }
                break;
            case 9:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c9-shops", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c9-shops", "false");
                }
                break;
            case 10:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c10-shops", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c10-shops", "false");
                }
                break;
            case 11:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c11-shops", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c11-shops", "false");
                }
                break;
            case 12:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c12-shops", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c12-shops", "false");
                }
                break;
        }
    }
}
