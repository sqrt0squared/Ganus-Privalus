using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ludiq;
using Bolt;

public class Planes : MonoBehaviour
{
    public Toggle toggle;

    public void onToggle()
    {
        switch (Variables.ActiveScene.Get("Selected"))
        {
            case 1:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c1-planes", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c1-planes", "false");
                }
                break;
            case 2:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c2-planes", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c2-planes", "false");
                }
                break;
            case 3:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c3-planes", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c3-planes", "false");
                }
                break;
            case 4:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c4-planes", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c4-planes", "false");
                }
                break;
            case 5:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c5-planes", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c5-planes", "false");
                }
                break;
            case 6:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c6-planes", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c6-planes", "false");
                }
                break;
            case 7:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c7-planes", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c7-planes", "false");
                }
                break;
            case 8:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c8-planes", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c8-planes", "false");
                }
                break;
            case 9:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c9-planes", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c9-planes", "false");
                }
                break;
            case 10:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c10-planes", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c10-planes", "false");
                }
                break;
            case 11:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c11-planes", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c11-planes", "false");
                }
                break;
            case 12:
                if (toggle.isOn)
                {
                    PlayerPrefs.SetString("c12-planes", "true");
                }
                else
                {
                    PlayerPrefs.SetString("c12-planes", "false");
                }
                break;
        }
    }
}
