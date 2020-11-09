using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Ludiq;
using Bolt;

public class GameManager : MonoBehaviour
{
    ArrayList restrictions = new ArrayList();
    ArrayList cureRandom = new ArrayList();

    public static float infected;
    public static int dead;
    public int lastdead;
    public static long healthy;
    public static long wholePopulation;
    
    public static int c1;
    public static int c2;
    public static int c3;
    public static int c4;
    public static int c5;
    public static int c6;
    public static int c7;
    public static int c8;
    public static int c9;
    public static int c10;
    public static int c11;
    public static long c12;

    public static int infected1;
    public static int infected2;
    public static int infected3;
    public static int infected4;
    public static int infected5;
    public static int infected6;
    public static int infected7;
    public static int infected8;
    public static int infected9;
    public static int infected10;
    public static int infected11;
    public static int infected12;

    public static int newinfected;
    public static int newinfected1;
    public static int newinfected2;
    public static int newinfected3;
    public static int newinfected4;
    public static int newinfected5;
    public static int newinfected6;
    public static int newinfected7;
    public static int newinfected8;
    public static int newinfected9;
    public static int newinfected10;
    public static int newinfected11;
    public static int newinfected12;

    public static int dead1;
    public static int dead2;
    public static int dead3;
    public static int dead4;
    public static int dead5;
    public static int dead6;
    public static int dead7;
    public static int dead8;
    public static int dead9;
    public static int dead10;
    public static int dead11;
    public static int dead12;

    public static int healthy1;
    public static int healthy2;
    public static int healthy3;
    public static int healthy4;
    public static int healthy5;
    public static int healthy6;
    public static int healthy7;
    public static int healthy8;
    public static int healthy9;
    public static int healthy10;
    public static int healthy11;
    public static int healthy12;

    public static int restrictions1;
    public static int restrictions2;
    public static int restrictions3;
    public static int restrictions4;
    public static int restrictions5;
    public static int restrictions6;
    public static int restrictions7;
    public static int restrictions8;
    public static int restrictions9;
    public static int restrictions10;
    public static int restrictions11;
    public static int restrictions12;

    public int cureState;
    public int time;
    public int lasttime;
    public int virusLevel;
    public bool research;
    public int maxNum;

    static Slider cureSlider;
    static Text population;
    static Text infectedText;
    static Text deadText;
    static Text curePercentage;
    static Text message;

    void Start()
    {
        population = GameObject.Find("Population").GetComponentInChildren<Text>();
        infectedText = GameObject.Find("Infected").GetComponentInChildren<Text>();
        deadText = GameObject.Find("Dead").GetComponentInChildren<Text>();
        curePercentage = GameObject.Find("CurePercentage").GetComponentInChildren<Text>();
        message = GameObject.Find("Message").GetComponentInChildren<Text>();
        cureSlider = GameObject.Find("CureSlider").GetComponent<Slider>();

        cureRandom.Clear();
        cureRandom.Add(1);
        cureRandom.Add(2);

        if (PlayerPrefs.GetString("play") == "new")
        {
            c1 = 10500000;
            c2 = 10000000;
            c3 = 50000000;
            c4 = 1000000000;
            c5 = 10000000;
            c6 = 1500000000;
            c7 = 400000000;
            c8 = 800000000;
            c9 = 900000000;
            c10 = 1250000000;
            c11 = 1400000000;
            c12 = 2669500000;
            healthy1 = c1;
            healthy2 = c2;
            healthy3 = c3;
            healthy4 = c4;
            healthy5 = c5;
            healthy6 = c6;
            healthy7 = c7;
            healthy8 = c8;
            healthy9 = c9;
            healthy10 = c10;
            healthy11 = c11;
            healthy12 = (int)c12;
            wholePopulation = 10000000000;
            healthy = wholePopulation;
            dead = 0;
            lastdead = 0;
            infected = 0;
            cureState = 0;
            time = 0;
            maxNum = 10;
            research = false;
            virusLevel = 1;
            cureSlider.value = cureState;
            curePercentage.text = cureState.ToString() + "%";
            population.text = "Population: " + wholePopulation.ToString();

            PlayerPrefs.SetString("c1-sports", "false");
            PlayerPrefs.SetString("c1-ships", "false");
            PlayerPrefs.SetString("c1-planes", "false");
            PlayerPrefs.SetString("c1-lockdown", "false");
            PlayerPrefs.SetString("c1-limited", "false");
            PlayerPrefs.SetString("c1-shops", "false");

            PlayerPrefs.SetString("c2-sports", "false");
            PlayerPrefs.SetString("c2-Ships", "false");
            PlayerPrefs.SetString("c2-planes", "false");
            PlayerPrefs.SetString("c2-lockdown", "false");
            PlayerPrefs.SetString("c2-limited", "false");
            PlayerPrefs.SetString("c2-shops", "false");

            PlayerPrefs.SetString("c3-sports", "false");
            PlayerPrefs.SetString("c3-ships", "false");
            PlayerPrefs.SetString("c3-planes", "false");
            PlayerPrefs.SetString("c3-lockdown", "false");
            PlayerPrefs.SetString("c3-limited", "false");
            PlayerPrefs.SetString("c3-shops", "false");

            PlayerPrefs.SetString("c4-sports", "false");
            PlayerPrefs.SetString("c4-ships", "false");
            PlayerPrefs.SetString("c4-planes", "false");
            PlayerPrefs.SetString("c4-lockdown", "false");
            PlayerPrefs.SetString("c4-limited", "false");
            PlayerPrefs.SetString("c4-shops", "false");

            PlayerPrefs.SetString("c5-sports", "false");
            PlayerPrefs.SetString("c5-ships", "false");
            PlayerPrefs.SetString("c5-planes", "false");
            PlayerPrefs.SetString("c5-lockdown", "false");
            PlayerPrefs.SetString("c5-limited", "false");
            PlayerPrefs.SetString("c5-shops", "false");

            PlayerPrefs.SetString("c6-sports", "false");
            PlayerPrefs.SetString("c6-ships", "false");
            PlayerPrefs.SetString("c6-planes", "false");
            PlayerPrefs.SetString("c6-lockdown", "false");
            PlayerPrefs.SetString("c6-limited", "false");
            PlayerPrefs.SetString("c6-shops", "false");

            PlayerPrefs.SetString("c7-sports", "false");
            PlayerPrefs.SetString("c7-ships", "false");
            PlayerPrefs.SetString("c7-planes", "false");
            PlayerPrefs.SetString("c7-lockdown", "false");
            PlayerPrefs.SetString("c7-limited", "false");
            PlayerPrefs.SetString("c7-shops", "false");

            PlayerPrefs.SetString("c8-sports", "false");
            PlayerPrefs.SetString("c8-ships", "false");
            PlayerPrefs.SetString("c8-planes", "false");
            PlayerPrefs.SetString("c8-lockdown", "false");
            PlayerPrefs.SetString("c8-limited", "false");
            PlayerPrefs.SetString("c8-shops", "false");

            PlayerPrefs.SetString("c9-sports", "false");
            PlayerPrefs.SetString("c9-ships", "false");
            PlayerPrefs.SetString("c9-planes", "false");
            PlayerPrefs.SetString("c9-lockdown", "false");
            PlayerPrefs.SetString("c9-limited", "false");
            PlayerPrefs.SetString("c9-shops", "false");

            PlayerPrefs.SetString("c10-sports", "false");
            PlayerPrefs.SetString("c10-ships", "false");
            PlayerPrefs.SetString("c10-planes", "false");
            PlayerPrefs.SetString("c10-lockdown", "false");
            PlayerPrefs.SetString("c10-limited", "false");
            PlayerPrefs.SetString("c10-shops", "false");

            PlayerPrefs.SetString("c11-sports", "false");
            PlayerPrefs.SetString("c11-ships", "false");
            PlayerPrefs.SetString("c11-planes", "false");
            PlayerPrefs.SetString("c11-lockdown", "false");
            PlayerPrefs.SetString("c11-limited", "false");
            PlayerPrefs.SetString("c11-shops", "false");

            PlayerPrefs.SetString("c12-sports", "false");
            PlayerPrefs.SetString("c12-ships", "false");
            PlayerPrefs.SetString("c12-planes", "false");
            PlayerPrefs.SetString("c12-lockdown", "false");
            PlayerPrefs.SetString("c12-limited", "false");
            PlayerPrefs.SetString("c12-shops", "false");
            
            infected = 1;
            healthy -= 1;

            restrictions1 = 0;
            restrictions2 = 0;
            restrictions3 = 0;
            restrictions4 = 0;
            restrictions5 = 0;
            restrictions6 = 0;
            restrictions7 = 0;
            restrictions8 = 0;
            restrictions9 = 0;
            restrictions10 = 0;
            restrictions11 = 0;
            restrictions12 = 0;

            StartCoroutine(FirstMessage());
            StartCoroutine(Infecting());
        }
        else if(PlayerPrefs.GetString("play") == "continue")
        {
            c1 = PlayerPrefs.GetInt("c1");
            c2 = PlayerPrefs.GetInt("c2");
            c3 = PlayerPrefs.GetInt("c3");
            c4 = PlayerPrefs.GetInt("c4");
            c5 = PlayerPrefs.GetInt("c5");
            c6 = PlayerPrefs.GetInt("c6");
            c7 = PlayerPrefs.GetInt("c7");
            c8 = PlayerPrefs.GetInt("c8");
            c9 = PlayerPrefs.GetInt("c9");
            c10 = PlayerPrefs.GetInt("c10");
            c11 = PlayerPrefs.GetInt("c11");
            c12 = PlayerPrefs.GetInt("c12");
            wholePopulation = PlayerPrefs.GetInt("wholePopulation");
            healthy = PlayerPrefs.GetInt("healthy");
            dead = PlayerPrefs.GetInt("dead");
            infected = PlayerPrefs.GetInt("infected");
            cureState = PlayerPrefs.GetInt("cureState");
            cureSlider.value = cureState;
            population.text = "Population: " + wholePopulation.ToString();
        }
    }

    public void saveGame()
    {
        PlayerPrefs.SetInt("c1", c1);
        PlayerPrefs.SetInt("c2", c2);
        PlayerPrefs.SetInt("c3", c3);
        PlayerPrefs.SetInt("c4", c4);
        PlayerPrefs.SetInt("c5", c5);
        PlayerPrefs.SetInt("c6", c6);
        PlayerPrefs.SetInt("c7", c7);
        PlayerPrefs.SetInt("c8", c8);
        PlayerPrefs.SetInt("c9", c9);
        PlayerPrefs.SetInt("c10", c10);
        PlayerPrefs.SetInt("c11", c11);
        PlayerPrefs.SetInt("c12", (int)c12);
        PlayerPrefs.SetInt("wholePopulation", (int)wholePopulation);
        PlayerPrefs.SetInt("healthy", (int)healthy);
        PlayerPrefs.SetInt("dead", (int)dead);
        PlayerPrefs.SetInt("infected", (int)infected);
        PlayerPrefs.SetInt("cureState", (int)cureState);
    }

    void Update()
    {
        switch(Variables.ActiveScene.Get("Selected")) 
        {
            default:
                population.text = (wholePopulation).ToString();
                infectedText.text = (infected).ToString();
                deadText.text = (dead).ToString();
                break;
            case 1:
                population.text = (c1).ToString();
                infectedText.text = (infected1).ToString();
                deadText.text = (dead1).ToString();
                break;
            case 2:
                population.text = (c2).ToString();
                infectedText.text = (infected2).ToString();
                deadText.text = (dead2).ToString();
                break;
            case 3:
                population.text = (c3).ToString();
                infectedText.text = (infected3).ToString();
                deadText.text = (dead3).ToString();
                break;
            case 4:
                population.text = (c4).ToString();
                infectedText.text = (infected4).ToString();
                deadText.text = (dead4).ToString();
                break;
            case 5:
                population.text = (c5).ToString();
                infectedText.text = (infected5).ToString();
                deadText.text = (dead5).ToString();
                break;
            case 6:
                population.text = (c6).ToString();
                infectedText.text = (infected6).ToString();
                deadText.text = (dead6).ToString();
                break;
            case 7:
                population.text = (c7).ToString();
                infectedText.text = (infected7).ToString();
                deadText.text = (dead7).ToString();
                break;
            case 8:
                population.text = (c8).ToString();
                infectedText.text = (infected8).ToString();
                deadText.text = (dead8).ToString();
                break;
            case 9:
                population.text = (c9).ToString();
                infectedText.text = (infected9).ToString();
                deadText.text = (dead9).ToString();
                break;
            case 10:
                population.text = (c10).ToString();
                infectedText.text = (infected10).ToString();
                deadText.text = (dead10).ToString();
                break;
            case 11:
                population.text = (c11).ToString();
                infectedText.text = (infected11).ToString();
                deadText.text = (dead11).ToString();
                break;
            case 12:
                population.text = (c12).ToString();
                infectedText.text = (infected12).ToString();
                deadText.text = (dead12).ToString();
                break;
        }
    }

    public void StartResearchButton()
    {
        if(!research)
        {
            if(time > 300)
            {
                StartCoroutine(StartResearch());
            }
            else
            {
                StartCoroutine(Error());
            }
        }
    }

    IEnumerator FirstMessage()
    {
        message.text = "First Ganus Privalus case in the world";
        infected1 = 1;
        healthy1 -= 1;

        infected2 = 1;
        healthy2 -= 1;

        infected3 = 1;
        healthy3 -= 1;

        infected4 = 1;
        healthy4 -= 1;
                
        infected5 = 1;
        healthy5 -= 1;
                
        infected6 = 1;
        healthy6 -= 1;
                
        infected7 = 1;
        healthy7 -= 1;
                
        infected8 = 1;
        healthy8 -= 1;
                
        infected9 = 1;
        healthy9 -= 1;
                
        infected10 = 1;
        healthy10 -= 1;
                
        infected11 = 1;
        healthy11 -= 1;
               
        infected12 = 1;
        healthy12 -= 1;

        yield return new WaitForSeconds(5f);
        message.text = "";
    }

    IEnumerator FirstDeath()
    {
        message.text = "First Ganus Privalus death in the world";
        yield return new WaitForSeconds(5f);
        message.text = "";
    }

    IEnumerator Error()
    {
        message.text = "Can't start research now (it is too early)";
        yield return new WaitForSeconds(5f);
        message.text = "";
    }

    IEnumerator StopResearch()
    {
        message.text = "Research has been stopped";
        yield return new WaitForSeconds(5f);
        message.text = "";
    }

    IEnumerator StartResearch()
    {
        message.text = "Research of cure has started";
        yield return new WaitForSeconds(5f);
        message.text = "";
        research = true;
        StartCoroutine(Mutation());
        while (research)
        {
            yield return new WaitForSeconds(virusLevel*10);
            int random = Random.Range((int)cureRandom[0], cureRandom.Count+1);
            cureState += random;
            if(cureState + random < 100)
            {
                cureSlider.value = cureState;
                curePercentage.text = cureState.ToString() + "%";
            }
            else
            {
                SceneManager.LoadScene("WinGame");
            }
        }
    }

    IEnumerator Mutation()
    {
        message.text = "Ganus Privalus mutated";
        virusLevel += 1;
        yield return new WaitForSeconds(5f);
        message.text = "";
    }

    IEnumerator Infecting()
    {
        while(true)
        {
            if(wholePopulation == 0)
            {
                SceneManager.LoadScene("GameOver");
            }

            if(dead >= 1 && lastdead == 0)
            {
                FirstDeath();   
            }

            if(time >= 60 && lasttime < 60)
            {
                StartCoroutine(Mutation());
                maxNum = 20;
            }
            else if(time >= 180 && lasttime < 180)
            {
                StartCoroutine(Mutation());
                maxNum = 40;
            }
            else if (time >= 360 && lasttime < 360)
            {
                StartCoroutine(Mutation());
                maxNum = 80;
            }
            else if (time >= 660 && lasttime < 660)
            {
                StartCoroutine(Mutation());
                maxNum = 160;
            }
            else if (time >= 1020 && lasttime < 1020)
            {
                StartCoroutine(Mutation());
                maxNum = 320;
            }
            else if (time >= 1500 && lasttime < 1500)
            {
                StartCoroutine(Mutation());
                maxNum = 640;
            }

            lastdead = dead;

            if(PlayerPrefs.GetString("c1-sports") == "true")
            {
                restrictions1 += 1;
            }
            if(PlayerPrefs.GetString("c1-planes") == "true")
            {
                restrictions1 += 1;
            }
            if (PlayerPrefs.GetString("c1-ships") == "true")
            {
                restrictions1 += 1;
            }
            if (PlayerPrefs.GetString("c1-shops") == "true")
            {
                restrictions1 += 1;
            }
            if (PlayerPrefs.GetString("c1-limited") == "true")
            {
                restrictions1 += 1;
            }
            if (PlayerPrefs.GetString("c1-lockdown") == "true")
            {
                restrictions1 += 1;
            }

            if (PlayerPrefs.GetString("c2-sports") == "true")
            {
                restrictions2 += 1;
            }
            if (PlayerPrefs.GetString("c2-planes") == "true")
            {
                restrictions2 += 1;
            }
            if (PlayerPrefs.GetString("c2-ships") == "true")
            {
                restrictions2 += 1;
            }
            if (PlayerPrefs.GetString("c2-shops") == "true")
            {
                restrictions2 += 1;
            }
            if (PlayerPrefs.GetString("c2-limited") == "true")
            {
                restrictions2 += 1;
            }
            if (PlayerPrefs.GetString("c2-lockdown") == "true")
            {
                restrictions2 += 1;
            }

            if (PlayerPrefs.GetString("c3-sports") == "true")
            {
                restrictions3 += 1;
            }
            if (PlayerPrefs.GetString("c3-planes") == "true")
            {
                restrictions3 += 1;
            }
            if (PlayerPrefs.GetString("c3-ships") == "true")
            {
                restrictions3 += 1;
            }
            if (PlayerPrefs.GetString("c3-shops") == "true")
            {
                restrictions3 += 1;
            }
            if (PlayerPrefs.GetString("c3-limited") == "true")
            {
                restrictions3 += 1;
            }
            if (PlayerPrefs.GetString("c3-lockdown") == "true")
            {
                restrictions3 += 1;
            }

            if (PlayerPrefs.GetString("c4-sports") == "true")
            {
                restrictions4 += 1;
            }
            if (PlayerPrefs.GetString("c4-planes") == "true")
            {
                restrictions4 += 1;
            }
            if (PlayerPrefs.GetString("c4-ships") == "true")
            {
                restrictions4 += 1;
            }
            if (PlayerPrefs.GetString("c4-shops") == "true")
            {
                restrictions4 += 1;
            }
            if (PlayerPrefs.GetString("c4-limited") == "true")
            {
                restrictions4 += 1;
            }
            if (PlayerPrefs.GetString("c4-lockdown") == "true")
            {
                restrictions4 += 1;
            }

            if (PlayerPrefs.GetString("c5-sports") == "true")
            {
                restrictions5 += 1;
            }
            if (PlayerPrefs.GetString("c5-planes") == "true")
            {
                restrictions5 += 1;
            }
            if (PlayerPrefs.GetString("c5-ships") == "true")
            {
                restrictions5 += 1;
            }
            if (PlayerPrefs.GetString("c5-shops") == "true")
            {
                restrictions5 += 1;
            }
            if (PlayerPrefs.GetString("c5-limited") == "true")
            {
                restrictions5 += 1;
            }
            if (PlayerPrefs.GetString("c5-lockdown") == "true")
            {
                restrictions5 += 1;
            }

            if (PlayerPrefs.GetString("c6-sports") == "true")
            {
                restrictions6 += 1;
            }
            if (PlayerPrefs.GetString("c6-planes") == "true")
            {
                restrictions6 += 1;
            }
            if (PlayerPrefs.GetString("c6-ships") == "true")
            {
                restrictions6 += 1;
            }
            if (PlayerPrefs.GetString("c6-shops") == "true")
            {
                restrictions6 += 1;
            }
            if (PlayerPrefs.GetString("c6-limited") == "true")
            {
                restrictions6 += 1;
            }
            if (PlayerPrefs.GetString("c6-lockdown") == "true")
            {
                restrictions6 += 1;
            }

            if (PlayerPrefs.GetString("c7-sports") == "true")
            {
                restrictions7 += 1;
            }
            if (PlayerPrefs.GetString("c7-planes") == "true")
            {
                restrictions7 += 1;
            }
            if (PlayerPrefs.GetString("c7-ships") == "true")
            {
                restrictions7 += 1;
            }
            if (PlayerPrefs.GetString("c7-shops") == "true")
            {
                restrictions7 += 1;
            }
            if (PlayerPrefs.GetString("c7-limited") == "true")
            {
                restrictions7 += 1;
            }
            if (PlayerPrefs.GetString("c7-lockdown") == "true")
            {
                restrictions7 += 1;
            }

            if (PlayerPrefs.GetString("c8-sports") == "true")
            {
                restrictions8 += 1;
            }
            if (PlayerPrefs.GetString("c8-planes") == "true")
            {
                restrictions8 += 1;
            }
            if (PlayerPrefs.GetString("c8-ships") == "true")
            {
                restrictions8 += 1;
            }
            if (PlayerPrefs.GetString("c8-shops") == "true")
            {
                restrictions8 += 1;
            }
            if (PlayerPrefs.GetString("c8-limited") == "true")
            {
                restrictions8 += 1;
            }
            if (PlayerPrefs.GetString("c8-lockdown") == "true")
            {
                restrictions8 += 1;
            }

            if (PlayerPrefs.GetString("c9-sports") == "true")
            {
                restrictions9 += 1;
            }
            if (PlayerPrefs.GetString("c9-planes") == "true")
            {
                restrictions9 += 1;
            }
            if (PlayerPrefs.GetString("c9-ships") == "true")
            {
                restrictions9 += 1;
            }
            if (PlayerPrefs.GetString("c9-shops") == "true")
            {
                restrictions9 += 1;
            }
            if (PlayerPrefs.GetString("c9-limited") == "true")
            {
                restrictions9 += 1;
            }
            if (PlayerPrefs.GetString("c9-lockdown") == "true")
            {
                restrictions9 += 1;
            }

            if (PlayerPrefs.GetString("c10-sports") == "true")
            {
                restrictions10 += 1;
            }
            if (PlayerPrefs.GetString("c10-planes") == "true")
            {
                restrictions10 += 1;
            }
            if (PlayerPrefs.GetString("c10-ships") == "true")
            {
                restrictions10 += 1;
            }
            if (PlayerPrefs.GetString("c10-shops") == "true")
            {
                restrictions10 += 1;
            }
            if (PlayerPrefs.GetString("c10-limited") == "true")
            {
                restrictions10 += 1;
            }
            if (PlayerPrefs.GetString("c10-lockdown") == "true")
            {
                restrictions10 += 1;
            }

            if (PlayerPrefs.GetString("c11-sports") == "true")
            {
                restrictions11 += 1;
            }
            if (PlayerPrefs.GetString("c11-planes") == "true")
            {
                restrictions11 += 1;
            }
            if (PlayerPrefs.GetString("c11-ships") == "true")
            {
                restrictions11 += 1;
            }
            if (PlayerPrefs.GetString("c11-shops") == "true")
            {
                restrictions11 += 1;
            }
            if (PlayerPrefs.GetString("c11-limited") == "true")
            {
                restrictions11 += 1;
            }
            if (PlayerPrefs.GetString("c11-lockdown") == "true")
            {
                restrictions11 += 1;
            }

            if (PlayerPrefs.GetString("c12-sports") == "true")
            {
                restrictions12 += 1;
            }
            if (PlayerPrefs.GetString("c12-planes") == "true")
            {
                restrictions12 += 1;
            }
            if (PlayerPrefs.GetString("c12-ships") == "true")
            {
                restrictions12 += 1;
            }
            if (PlayerPrefs.GetString("c12-shops") == "true")
            {
                restrictions12 += 1;
            }
            if (PlayerPrefs.GetString("c12-limited") == "true")
            {
                restrictions12 += 1;
            }
            if (PlayerPrefs.GetString("c12-lockdown") == "true")
            {
                restrictions12 += 1;
            }

            
            int random = Random.Range(1, maxNum);
            int random1 = Random.Range(1, restrictions1+1);
            if (random - random1 < 0)
            {
                newinfected1 = Mathf.RoundToInt(virusLevel * 0);
            }
            else
            {
                newinfected1 = Mathf.RoundToInt(virusLevel * (random - random1));
            }

            random = Random.Range(1, maxNum);
            random1 = Random.Range(1, restrictions2 + 1);
            if (random - random1 < 0)
            {
                newinfected2 = Mathf.RoundToInt(virusLevel * 0);
            }
            else
            {
                newinfected2 = Mathf.RoundToInt(virusLevel * (random - random1));
            }

            random = Random.Range(1, maxNum);
            random1 = Random.Range(1, restrictions3 + 1);
            if (random - random1 < 0)
            {
                newinfected3 = Mathf.RoundToInt(virusLevel * 0);
            }
            else
            {
                newinfected3 = Mathf.RoundToInt(virusLevel * (random - random1));
            }

            random = Random.Range(1, maxNum);
            random1 = Random.Range(1, restrictions4 + 1);
            if (random - random1 < 0)
            {
                newinfected4 = Mathf.RoundToInt(virusLevel * 0);
            }
            else
            {
                newinfected4 = Mathf.RoundToInt(virusLevel * (random - random1));
            }

            random = Random.Range(1, maxNum);
            random1 = Random.Range(1, restrictions5 + 1);
            if (random - random1 < 0)
            {
                newinfected5 = Mathf.RoundToInt(virusLevel * 0);
            }
            else
            {
                newinfected5 = Mathf.RoundToInt(virusLevel * (random - random1));
            }

            random = Random.Range(1, maxNum);
            random1 = Random.Range(1, restrictions6 + 1);
            if (random - random1 < 0)
            {
                newinfected6 = Mathf.RoundToInt(virusLevel * 0);
            }
            else
            {
                newinfected6 = Mathf.RoundToInt(virusLevel * (random - random1));
            }

            random = Random.Range(1, maxNum);
            random1 = Random.Range(1, restrictions7 + 1);
            if (random - random1 < 0)
            {
                newinfected7 = Mathf.RoundToInt(virusLevel * 0);
            }
            else
            {
                newinfected7 = Mathf.RoundToInt(virusLevel * (random - random1));
            }

            random = Random.Range(1, maxNum);
            random1 = Random.Range(1, restrictions8 + 1);
            if (random - random1 < 0)
            {
                newinfected8 = Mathf.RoundToInt(virusLevel * 0);
            }
            else
            {
                newinfected8 = Mathf.RoundToInt(virusLevel * (random - random1));
            }

            random = Random.Range(1, maxNum);
            random1 = Random.Range(1, restrictions9 + 1);
            if (random - random1 < 0)
            {
                newinfected9 = Mathf.RoundToInt(virusLevel * 0);
            }
            else
            {
                newinfected9 = Mathf.RoundToInt(virusLevel * (random - random1));
            }

            random = Random.Range(1, maxNum);
            random1 = Random.Range(1, restrictions10 + 1);
            if (random - random1 < 0)
            {
                newinfected10 = Mathf.RoundToInt(virusLevel * 0);
            }
            else
            {
                newinfected10 = Mathf.RoundToInt(virusLevel * (random - random1));
            }

            random = Random.Range(1, maxNum);
            random1 = Random.Range(1, restrictions11 + 1);
            if (random - random1 < 0)
            {
                newinfected11 = Mathf.RoundToInt(virusLevel * 0);
            }
            else
            {
                newinfected11 = Mathf.RoundToInt(virusLevel * (random - random1));
            }

            random = Random.Range(1, maxNum);
            random1 = Random.Range(1, restrictions12 + 1);
            if(random-random1 < 0)
            {
                newinfected12 = Mathf.RoundToInt(virusLevel * 0);
            }
            else
            {
                newinfected12 = Mathf.RoundToInt(virusLevel * (random - random1));
            }

            newinfected = newinfected1+newinfected2+newinfected3+newinfected4+newinfected5+newinfected6+newinfected7+newinfected8+newinfected9+newinfected10+newinfected11+newinfected12;

            dead1 = dead1 + Mathf.RoundToInt(newinfected1 / 4) * (virusLevel-1);
            dead2 = dead2 + Mathf.RoundToInt(newinfected2 / 4) * (virusLevel - 1);
            dead3 = dead3 + Mathf.RoundToInt(newinfected3 / 4) * (virusLevel - 1);
            dead4 = dead4 + Mathf.RoundToInt(newinfected4 / 4) * (virusLevel - 1);
            dead5 = dead5 + Mathf.RoundToInt(newinfected5 / 4) * (virusLevel - 1);
            dead6 = dead6 + Mathf.RoundToInt(newinfected6 / 4) * (virusLevel - 1);
            dead7 = dead7 + Mathf.RoundToInt(newinfected7 / 4) * (virusLevel - 1);
            dead8 = dead8 + Mathf.RoundToInt(newinfected8 / 4) * (virusLevel - 1);
            dead9 = dead9 + Mathf.RoundToInt(newinfected9 / 4) * (virusLevel - 1);
            dead10 = dead10 + Mathf.RoundToInt(newinfected10 / 4) * (virusLevel - 1);
            dead11 = dead11 + Mathf.RoundToInt(newinfected11 / 4) * (virusLevel - 1);
            dead12 = dead12 + Mathf.RoundToInt(newinfected12 / 4) * (virusLevel - 1);

            dead = dead1 + dead2 + dead3 + dead4 + dead5 + dead6 + dead7 + dead8 + dead9 + dead10 + dead11 + dead12;

            infected = infected + newinfected;
            infected1 = infected1 + newinfected1;
            infected2 = infected2 + newinfected2;
            infected3 = infected3 + newinfected3;
            infected4 = infected4 + newinfected4;
            infected5 = infected5 + newinfected5;
            infected6 = infected6 + newinfected6;
            infected7 = infected7 + newinfected7;
            infected8 = infected8 + newinfected8;
            infected9 = infected9 + newinfected9;
            infected10 = infected10 + newinfected10;
            infected11 = infected11 + newinfected11;
            infected12 = infected12 + newinfected12;

            healthy = healthy - newinfected;
            healthy1 = healthy1 - newinfected1;
            healthy2 = healthy2 - newinfected2;
            healthy3 = healthy3 - newinfected3;
            healthy4 = healthy4 - newinfected4;
            healthy5 = healthy5 - newinfected5;
            healthy6 = healthy6 - newinfected6;
            healthy7 = healthy7 - newinfected7;
            healthy8 = healthy8 - newinfected8;
            healthy9 = healthy9 - newinfected9;
            healthy10 = healthy10 - newinfected10;
            healthy11 = healthy11 - newinfected11;
            healthy12 = healthy12 - newinfected12;

            wholePopulation = 10000000000 - dead;
            c1 = c1 - dead1;
            c2 = c2 - dead2;
            c3 = c3 - dead3;
            c4 = c4 - dead4;
            c5 = c5 - dead5;
            c6 = c6 - dead6;
            c7 = c7 - dead7;
            c8 = c8 - dead8;
            c9 = c9 - dead9;
            c10 = c10 - dead10;
            c11 = c11 - dead11;
            c12 = c12 - dead12;

            yield return new WaitForSeconds(3f);
            lasttime = time;
            time += 3;
        }
    }
}
