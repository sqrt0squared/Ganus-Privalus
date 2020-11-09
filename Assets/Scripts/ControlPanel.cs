using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ludiq;
using Bolt;

public class ControlPanel : MonoBehaviour
{
    public Text worldSelected;
    [SerializeField] public GameObject ReallyControls;

    public Toggle sports;
    public Toggle ships;
    public Toggle planes;
    public Toggle lockdown;
    public Toggle limited;
    public Toggle shops;

    public Text populationTextCPanel;
    public Text healthyTextCPanel;
    public Text infectedTextCPanel;
    public Text deadTextCPanel;
    public Text doctorsText;

    public void check()
    {
        switch (Variables.ActiveScene.Get("Selected"))
        {
            default:
                worldSelected.text = "You can only control \nseparate countries.";
                ReallyControls.SetActive(false);
                populationTextCPanel.text = GameManager.wholePopulation.ToString();
                infectedTextCPanel.text = GameManager.infected.ToString();
                healthyTextCPanel.text = GameManager.healthy.ToString();
                deadTextCPanel.text = GameManager.dead.ToString();
                break;
            case 1:
                worldSelected.text = "";
                if (PlayerPrefs.GetString("c1-sports") == "true")
                {
                    sports.isOn = true;
                }
                else if (PlayerPrefs.GetString("c1-sports") == "false" || PlayerPrefs.GetString("c1-sports") == "")
                {
                    sports.isOn = false;
                }
                if (PlayerPrefs.GetString("c1-ships") == "true")
                {
                    ships.isOn = true;
                }
                else if (PlayerPrefs.GetString("c1-ships") == "false" || PlayerPrefs.GetString("c1-ships") == "")
                {
                    ships.isOn = false;
                }
                if (PlayerPrefs.GetString("c1-planes") == "true")
                {
                    planes.isOn = true;
                }
                else if (PlayerPrefs.GetString("c1-planes") == "false" || PlayerPrefs.GetString("c1-planes") == "")
                {
                    planes.isOn = false;
                }
                if (PlayerPrefs.GetString("c1-lockdown") == "true")
                {
                    lockdown.isOn = true;
                }
                else if (PlayerPrefs.GetString("c1-lockdown") == "false" || PlayerPrefs.GetString("c1-lockdown") == "")
                {
                    lockdown.isOn = false;
                }
                if (PlayerPrefs.GetString("c1-limited") == "true")
                {
                    limited.isOn = true;
                }
                else if (PlayerPrefs.GetString("c1-limited") == "false" || PlayerPrefs.GetString("c1-limited") == "")
                {
                    limited.isOn = false;
                }
                if (PlayerPrefs.GetString("c1-shops") == "true")
                {
                    shops.isOn = true;
                }
                else if (PlayerPrefs.GetString("c1-shops") == "false" || PlayerPrefs.GetString("c1-shops") == "")
                {
                    shops.isOn = false;
                }
                populationTextCPanel.text = GameManager.c1.ToString();
                infectedTextCPanel.text = GameManager.infected1.ToString();
                healthyTextCPanel.text = GameManager.healthy1.ToString();
                deadTextCPanel.text = GameManager.dead1.ToString();
                break;
            case 2:
                worldSelected.text = "";
                if (PlayerPrefs.GetString("c2-sports") == "true")
                {
                    sports.isOn = true;
                }
                else if (PlayerPrefs.GetString("c2-sports") == "false" || PlayerPrefs.GetString("c2-sports") == "")
                {
                    sports.isOn = false;
                }
                if (PlayerPrefs.GetString("c2-ships") == "true")
                {
                    ships.isOn = true;
                }
                else if (PlayerPrefs.GetString("c2-ships") == "false" || PlayerPrefs.GetString("c2-ships") == "")
                {
                    ships.isOn = false;
                }
                if (PlayerPrefs.GetString("c2-planes") == "true")
                {
                    planes.isOn = true;
                }
                else if (PlayerPrefs.GetString("c2-planes") == "false" || PlayerPrefs.GetString("c2-planes") == "")
                {
                    planes.isOn = false;
                }
                if (PlayerPrefs.GetString("c2-lockdown") == "true")
                {
                    lockdown.isOn = true;
                }
                else if (PlayerPrefs.GetString("c2-lockdown") == "false" || PlayerPrefs.GetString("c2-lockdown") == "")
                {
                    lockdown.isOn = false;
                }
                if (PlayerPrefs.GetString("c2-limited") == "true")
                {
                    limited.isOn = true;
                }
                else if (PlayerPrefs.GetString("c2-limited") == "false" || PlayerPrefs.GetString("c2-limited") == "")
                {
                    limited.isOn = false;
                }
                if (PlayerPrefs.GetString("c2-shops") == "true")
                {
                    shops.isOn = true;
                }
                else if (PlayerPrefs.GetString("c2-shops") == "false" || PlayerPrefs.GetString("c2-shops") == "")
                {
                    shops.isOn = false;
                }
                populationTextCPanel.text = GameManager.c2.ToString();
                infectedTextCPanel.text = GameManager.infected2.ToString();
                healthyTextCPanel.text = GameManager.healthy2.ToString();
                deadTextCPanel.text = GameManager.dead2.ToString();
                break;
            case 3:
                worldSelected.text = "";
                if (PlayerPrefs.GetString("c3-sports") == "true")
                {
                    sports.isOn = true;
                }
                else if (PlayerPrefs.GetString("c3-sports") == "false" || PlayerPrefs.GetString("c3-sports") == "")
                {
                    sports.isOn = false;
                }
                if (PlayerPrefs.GetString("c3-ships") == "true")
                {
                    ships.isOn = true;
                }
                else if (PlayerPrefs.GetString("c3-ships") == "false" || PlayerPrefs.GetString("c3-ships") == "")
                {
                    ships.isOn = false;
                }
                if (PlayerPrefs.GetString("c3-planes") == "true")
                {
                    planes.isOn = true;
                }
                else if (PlayerPrefs.GetString("c3-planes") == "false" || PlayerPrefs.GetString("c3-planes") == "")
                {
                    planes.isOn = false;
                }
                if (PlayerPrefs.GetString("c3-lockdown") == "true")
                {
                    lockdown.isOn = true;
                }
                else if (PlayerPrefs.GetString("c3-lockdown") == "false" || PlayerPrefs.GetString("c3-lockdown") == "")
                {
                    lockdown.isOn = false;
                }
                if (PlayerPrefs.GetString("c3-limited") == "true")
                {
                    limited.isOn = true;
                }
                else if (PlayerPrefs.GetString("c3-limited") == "false" || PlayerPrefs.GetString("c3-limited") == "")
                {
                    limited.isOn = false;
                }
                if (PlayerPrefs.GetString("c3-shops") == "true")
                {
                    shops.isOn = true;
                }
                else if (PlayerPrefs.GetString("c3-shops") == "false" || PlayerPrefs.GetString("c3-shops") == "")
                {
                    shops.isOn = false;
                }
                populationTextCPanel.text = GameManager.c3.ToString();
                infectedTextCPanel.text = GameManager.infected3.ToString();
                healthyTextCPanel.text = GameManager.healthy3.ToString();
                deadTextCPanel.text = GameManager.dead3.ToString();
                break;
            case 4:
                worldSelected.text = "";
                if (PlayerPrefs.GetString("c4-sports") == "true")
                {
                    sports.isOn = true;
                }
                else if (PlayerPrefs.GetString("c4-sports") == "false" || PlayerPrefs.GetString("c4-sports") == "")
                {
                    sports.isOn = false;
                }
                if (PlayerPrefs.GetString("c4-ships") == "true")
                {
                    ships.isOn = true;
                }
                else if (PlayerPrefs.GetString("c4-ships") == "false" || PlayerPrefs.GetString("c4-ships") == "")
                {
                    ships.isOn = false;
                }
                if (PlayerPrefs.GetString("c4-planes") == "true")
                {
                    planes.isOn = true;
                }
                else if (PlayerPrefs.GetString("c4-planes") == "false" || PlayerPrefs.GetString("c4-planes") == "")
                {
                    planes.isOn = false;
                }
                if (PlayerPrefs.GetString("c4-lockdown") == "true")
                {
                    lockdown.isOn = true;
                }
                else if (PlayerPrefs.GetString("c4-lockdown") == "false" || PlayerPrefs.GetString("c4-lockdown") == "")
                {
                    lockdown.isOn = false;
                }
                if (PlayerPrefs.GetString("c4-limited") == "true")
                {
                    limited.isOn = true;
                }
                else if (PlayerPrefs.GetString("c4-limited") == "false" || PlayerPrefs.GetString("c4-limited") == "")
                {
                    limited.isOn = false;
                }
                if (PlayerPrefs.GetString("c4-shops") == "true")
                {
                    shops.isOn = true;
                }
                else if (PlayerPrefs.GetString("c4-shops") == "false" || PlayerPrefs.GetString("c4-shops") == "")
                {
                    shops.isOn = false;
                }
                populationTextCPanel.text = GameManager.c4.ToString();
                infectedTextCPanel.text = GameManager.infected4.ToString();
                healthyTextCPanel.text = GameManager.healthy4.ToString();
                deadTextCPanel.text = GameManager.dead4.ToString();
                break;
            case 5:
                worldSelected.text = "";
                if (PlayerPrefs.GetString("c5-sports") == "true")
                {
                    sports.isOn = true;
                }
                else if (PlayerPrefs.GetString("c5-sports") == "false" || PlayerPrefs.GetString("c5-sports") == "")
                {
                    sports.isOn = false;
                }
                if (PlayerPrefs.GetString("c5-ships") == "true")
                {
                    ships.isOn = true;
                }
                else if (PlayerPrefs.GetString("c5-ships") == "false" || PlayerPrefs.GetString("c5-ships") == "")
                {
                    ships.isOn = false;
                }
                if (PlayerPrefs.GetString("c5-planes") == "true")
                {
                    planes.isOn = true;
                }
                else if (PlayerPrefs.GetString("c5-planes") == "false" || PlayerPrefs.GetString("c5-planes") == "")
                {
                    planes.isOn = false;
                }
                if (PlayerPrefs.GetString("c5-lockdown") == "true")
                {
                    lockdown.isOn = true;
                }
                else if (PlayerPrefs.GetString("c5-lockdown") == "false" || PlayerPrefs.GetString("c5-lockdown") == "")
                {
                    lockdown.isOn = false;
                }
                if (PlayerPrefs.GetString("c5-limited") == "true")
                {
                    limited.isOn = true;
                }
                else if (PlayerPrefs.GetString("c5-limited") == "false" || PlayerPrefs.GetString("c5-limited") == "")
                {
                    limited.isOn = false;
                }
                if (PlayerPrefs.GetString("c5-shops") == "true")
                {
                    shops.isOn = true;
                }
                else if (PlayerPrefs.GetString("c5-shops") == "false" || PlayerPrefs.GetString("c5-shops") == "")
                {
                    shops.isOn = false;
                }
                populationTextCPanel.text = GameManager.c5.ToString();
                infectedTextCPanel.text = GameManager.infected5.ToString();
                healthyTextCPanel.text = GameManager.healthy5.ToString();
                deadTextCPanel.text = GameManager.dead5.ToString();
                break;
            case 6:
                worldSelected.text = "";
                if (PlayerPrefs.GetString("c6-sports") == "true")
                {
                    sports.isOn = true;
                }
                else if (PlayerPrefs.GetString("c6-sports") == "false" || PlayerPrefs.GetString("c6-sports") == "")
                {
                    sports.isOn = false;
                }
                if (PlayerPrefs.GetString("c6-ships") == "true")
                {
                    ships.isOn = true;
                }
                else if (PlayerPrefs.GetString("c6-ships") == "false" || PlayerPrefs.GetString("c6-ships") == "")
                {
                    ships.isOn = false;
                }
                if (PlayerPrefs.GetString("c6-planes") == "true")
                {
                    planes.isOn = true;
                }
                else if (PlayerPrefs.GetString("c6-planes") == "false" || PlayerPrefs.GetString("c6-planes") == "")
                {
                    planes.isOn = false;
                }
                if (PlayerPrefs.GetString("c6-lockdown") == "true")
                {
                    lockdown.isOn = true;
                }
                else if (PlayerPrefs.GetString("c6-lockdown") == "false" || PlayerPrefs.GetString("c6-lockdown") == "")
                {
                    lockdown.isOn = false;
                }
                if (PlayerPrefs.GetString("c6-limited") == "true")
                {
                    limited.isOn = true;
                }
                else if (PlayerPrefs.GetString("c6-limited") == "false" || PlayerPrefs.GetString("c6-limited") == "")
                {
                    limited.isOn = false;
                }
                if (PlayerPrefs.GetString("c6-shops") == "true")
                {
                    shops.isOn = true;
                }
                else if (PlayerPrefs.GetString("c6-shops") == "false" || PlayerPrefs.GetString("c6-shops") == "")
                {
                    shops.isOn = false;
                }
                populationTextCPanel.text = GameManager.c6.ToString();
                infectedTextCPanel.text = GameManager.infected6.ToString();
                healthyTextCPanel.text = GameManager.healthy6.ToString();
                deadTextCPanel.text = GameManager.dead6.ToString();
                break;
            case 7:
                worldSelected.text = "";
                if (PlayerPrefs.GetString("c7-sports") == "true")
                {
                    sports.isOn = true;
                }
                else if (PlayerPrefs.GetString("c7-sports") == "false" || PlayerPrefs.GetString("c7-sports") == "")
                {
                    sports.isOn = false;
                }
                if (PlayerPrefs.GetString("c7-ships") == "true")
                {
                    ships.isOn = true;
                }
                else if (PlayerPrefs.GetString("c7-ships") == "false" || PlayerPrefs.GetString("c7-ships") == "")
                {
                    ships.isOn = false;
                }
                if (PlayerPrefs.GetString("c7-planes") == "true")
                {
                    planes.isOn = true;
                }
                else if (PlayerPrefs.GetString("c7-planes") == "false" || PlayerPrefs.GetString("c7-planes") == "")
                {
                    planes.isOn = false;
                }
                if (PlayerPrefs.GetString("c7-lockdown") == "true")
                {
                    lockdown.isOn = true;
                }
                else if (PlayerPrefs.GetString("c7-lockdown") == "false" || PlayerPrefs.GetString("c7-lockdown") == "")
                {
                    lockdown.isOn = false;
                }
                if (PlayerPrefs.GetString("c7-limited") == "true")
                {
                    limited.isOn = true;
                }
                else if (PlayerPrefs.GetString("c7-limited") == "false" || PlayerPrefs.GetString("c7-limited") == "")
                {
                    limited.isOn = false;
                }
                if (PlayerPrefs.GetString("c7-shops") == "true")
                {
                    shops.isOn = true;
                }
                else if (PlayerPrefs.GetString("c7-shops") == "false" || PlayerPrefs.GetString("c7-shops") == "")
                {
                    shops.isOn = false;
                }
                populationTextCPanel.text = GameManager.c7.ToString();
                infectedTextCPanel.text = GameManager.infected7.ToString();
                healthyTextCPanel.text = GameManager.healthy7.ToString();
                deadTextCPanel.text = GameManager.dead7.ToString();
                break;
            case 8:
                worldSelected.text = "";
                if (PlayerPrefs.GetString("c8-sports") == "true")
                {
                    sports.isOn = true;
                }
                else if (PlayerPrefs.GetString("c8-sports") == "false" || PlayerPrefs.GetString("c8-sports") == "")
                {
                    sports.isOn = false;
                }
                if (PlayerPrefs.GetString("c8-ships") == "true")
                {
                    ships.isOn = true;
                }
                else if (PlayerPrefs.GetString("c8-ships") == "false" || PlayerPrefs.GetString("c8-ships") == "")
                {
                    ships.isOn = false;
                }
                if (PlayerPrefs.GetString("c8-planes") == "true")
                {
                    planes.isOn = true;
                }
                else if (PlayerPrefs.GetString("c8-planes") == "false" || PlayerPrefs.GetString("c8-planes") == "")
                {
                    planes.isOn = false;
                }
                if (PlayerPrefs.GetString("c8-lockdown") == "true")
                {
                    lockdown.isOn = true;
                }
                else if (PlayerPrefs.GetString("c8-lockdown") == "false" || PlayerPrefs.GetString("c8-lockdown") == "")
                {
                    lockdown.isOn = false;
                }
                if (PlayerPrefs.GetString("c8-limited") == "true")
                {
                    limited.isOn = true;
                }
                else if (PlayerPrefs.GetString("c8-limited") == "false" || PlayerPrefs.GetString("c8-limited") == "")
                {
                    limited.isOn = false;
                }
                if (PlayerPrefs.GetString("c8-shops") == "true")
                {
                    shops.isOn = true;
                }
                else if (PlayerPrefs.GetString("c8-shops") == "false" || PlayerPrefs.GetString("c8-shops") == "")
                {
                    shops.isOn = false;
                }
                populationTextCPanel.text = GameManager.c8.ToString();
                infectedTextCPanel.text = GameManager.infected8.ToString();
                healthyTextCPanel.text = GameManager.healthy8.ToString();
                deadTextCPanel.text = GameManager.dead8.ToString();
                break;
            case 9:
                worldSelected.text = "";
                if (PlayerPrefs.GetString("c9-sports") == "true")
                {
                    sports.isOn = true;
                }
                else if (PlayerPrefs.GetString("c9-sports") == "false" || PlayerPrefs.GetString("c9-sports") == "")
                {
                    sports.isOn = false;
                }
                if (PlayerPrefs.GetString("c9-ships") == "true")
                {
                    ships.isOn = true;
                }
                else if (PlayerPrefs.GetString("c9-ships") == "false" || PlayerPrefs.GetString("c9-ships") == "")
                {
                    ships.isOn = false;
                }
                if (PlayerPrefs.GetString("c9-planes") == "true")
                {
                    planes.isOn = true;
                }
                else if (PlayerPrefs.GetString("c9-planes") == "false" || PlayerPrefs.GetString("c9-planes") == "")
                {
                    planes.isOn = false;
                }
                if (PlayerPrefs.GetString("c9-lockdown") == "true")
                {
                    lockdown.isOn = true;
                }
                else if (PlayerPrefs.GetString("c9-lockdown") == "false" || PlayerPrefs.GetString("c9-lockdown") == "")
                {
                    lockdown.isOn = false;
                }
                if (PlayerPrefs.GetString("c9-limited") == "true")
                {
                    limited.isOn = true;
                }
                else if (PlayerPrefs.GetString("c9-limited") == "false" || PlayerPrefs.GetString("c9-limited") == "")
                {
                    limited.isOn = false;
                }
                if (PlayerPrefs.GetString("c9-shops") == "true")
                {
                    shops.isOn = true;
                }
                else if (PlayerPrefs.GetString("c9-shops") == "false" || PlayerPrefs.GetString("c9-shops") == "")
                {
                    shops.isOn = false;
                }
                populationTextCPanel.text = GameManager.c9.ToString();
                infectedTextCPanel.text = GameManager.infected9.ToString();
                healthyTextCPanel.text = GameManager.healthy9.ToString();
                deadTextCPanel.text = GameManager.dead9.ToString();
                break;
            case 10:
                worldSelected.text = "";
                if (PlayerPrefs.GetString("c10-sports") == "true")
                {
                    sports.isOn = true;
                }
                else if (PlayerPrefs.GetString("c10-sports") == "false" || PlayerPrefs.GetString("c10-sports") == "")
                {
                    sports.isOn = false;
                }
                if (PlayerPrefs.GetString("c10-ships") == "true")
                {
                    ships.isOn = true;
                }
                else if (PlayerPrefs.GetString("c10-ships") == "false" || PlayerPrefs.GetString("c10-ships") == "")
                {
                    ships.isOn = false;
                }
                if (PlayerPrefs.GetString("c10-planes") == "true")
                {
                    planes.isOn = true;
                }
                else if (PlayerPrefs.GetString("c10-planes") == "false" || PlayerPrefs.GetString("c10-planes") == "")
                {
                    planes.isOn = false;
                }
                if (PlayerPrefs.GetString("c10-lockdown") == "true")
                {
                    lockdown.isOn = true;
                }
                else if (PlayerPrefs.GetString("c10-lockdown") == "false" || PlayerPrefs.GetString("c10-lockdown") == "")
                {
                    lockdown.isOn = false;
                }
                if (PlayerPrefs.GetString("c10-limited") == "true")
                {
                    limited.isOn = true;
                }
                else if (PlayerPrefs.GetString("c10-limited") == "false" || PlayerPrefs.GetString("c10-limited") == "")
                {
                    limited.isOn = false;
                }
                if (PlayerPrefs.GetString("c10-shops") == "true")
                {
                    shops.isOn = true;
                }
                else if (PlayerPrefs.GetString("c10-shops") == "false" || PlayerPrefs.GetString("c10-shops") == "")
                {
                    shops.isOn = false;
                }
                populationTextCPanel.text = GameManager.c10.ToString();
                infectedTextCPanel.text = GameManager.infected10.ToString();
                healthyTextCPanel.text = GameManager.healthy10.ToString();
                deadTextCPanel.text = GameManager.dead10.ToString();
                break;
            case 11:
                worldSelected.text = "";
                if (PlayerPrefs.GetString("c11-sports") == "true")
                {
                    sports.isOn = true;
                }
                else if (PlayerPrefs.GetString("c11-sports") == "false" || PlayerPrefs.GetString("c11-sports") == "")
                {
                    sports.isOn = false;
                }
                if (PlayerPrefs.GetString("c11-ships") == "true")
                {
                    ships.isOn = true;
                }
                else if (PlayerPrefs.GetString("c11-ships") == "false" || PlayerPrefs.GetString("c11-ships") == "")
                {
                    ships.isOn = false;
                }
                if (PlayerPrefs.GetString("c11-planes") == "true")
                {
                    planes.isOn = true;
                }
                else if (PlayerPrefs.GetString("c11-planes") == "false" || PlayerPrefs.GetString("c11-planes") == "")
                {
                    planes.isOn = false;
                }
                if (PlayerPrefs.GetString("c11-lockdown") == "true")
                {
                    lockdown.isOn = true;
                }
                else if (PlayerPrefs.GetString("c11-lockdown") == "false" || PlayerPrefs.GetString("c11-lockdown") == "")
                {
                    lockdown.isOn = false;
                }
                if (PlayerPrefs.GetString("c11-limited") == "true")
                {
                    limited.isOn = true;
                }
                else if (PlayerPrefs.GetString("c11-limited") == "false" || PlayerPrefs.GetString("c11-limited") == "")
                {
                    limited.isOn = false;
                }
                if (PlayerPrefs.GetString("c11-shops") == "true")
                {
                    shops.isOn = true;
                }
                else if (PlayerPrefs.GetString("c11-shops") == "false" || PlayerPrefs.GetString("c11-shops") == "")
                {
                    shops.isOn = false;
                }
                populationTextCPanel.text = GameManager.c11.ToString();
                infectedTextCPanel.text = GameManager.infected11.ToString();
                healthyTextCPanel.text = GameManager.healthy11.ToString();
                deadTextCPanel.text = GameManager.dead11.ToString();
                break;
            case 12:
                worldSelected.text = "";
                if (PlayerPrefs.GetString("c12-sports") == "true")
                {
                    sports.isOn = true;
                }
                else if (PlayerPrefs.GetString("c12-sports") == "false" || PlayerPrefs.GetString("c12-sports") == "")
                {
                    sports.isOn = false;
                }
                if (PlayerPrefs.GetString("c12-ships") == "true")
                {
                    ships.isOn = true;
                }
                else if (PlayerPrefs.GetString("c12-ships") == "false" || PlayerPrefs.GetString("c12-ships") == "")
                {
                    ships.isOn = false;
                }
                if (PlayerPrefs.GetString("c12-planes") == "true")
                {
                    planes.isOn = true;
                }
                else if (PlayerPrefs.GetString("c12-planes") == "false" || PlayerPrefs.GetString("c12-planes") == "")
                {
                    planes.isOn = false;
                }
                if (PlayerPrefs.GetString("c12-lockdown") == "true")
                {
                    lockdown.isOn = true;
                }
                else if (PlayerPrefs.GetString("c12-lockdown") == "false" || PlayerPrefs.GetString("c12-lockdown") == "")
                {
                    lockdown.isOn = false;
                }
                if (PlayerPrefs.GetString("c12-limited") == "true")
                {
                    limited.isOn = true;
                }
                else if (PlayerPrefs.GetString("c12-limited") == "false" || PlayerPrefs.GetString("c12-limited") == "")
                {
                    limited.isOn = false;
                }
                if (PlayerPrefs.GetString("c12-shops") == "true")
                {
                    shops.isOn = true;
                }
                else if (PlayerPrefs.GetString("c12-shops") == "false" || PlayerPrefs.GetString("c12-shops") == "")
                {
                    shops.isOn = false;
                }
                populationTextCPanel.text = GameManager.c12.ToString();
                infectedTextCPanel.text = GameManager.infected12.ToString();
                healthyTextCPanel.text = GameManager.healthy12.ToString();
                deadTextCPanel.text = GameManager.dead12.ToString();
                break;
        }
    }
}
