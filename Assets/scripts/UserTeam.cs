using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UserTeam : MonoBehaviour
{
    public GameObject teamKnightsHome;
    public GameObject teamWavesHome;
    public GameObject teamKnightsAway;
    public GameObject teamWavesAway;
    public GameObject batter;
    public GameObject pitcher;
    public GameObject redPitchingChance;
    public GameObject redHitChance;
    public float power;
    public float contact;
    public float velocity;
    public float control;
    public float otherteampower;
    public float otherteamcontact;
    public float otherteamvelocity;
    public float otherteamcontrol;
    public string side;

    void Start()
    {
        Debug.Log(PlayerPrefs.GetString("teamname"));
        teamKnightsHome.SetActive(false);
        teamWavesHome.SetActive(false);
        teamKnightsAway.SetActive(false);
        teamWavesAway.SetActive(false);
        batter.GetComponent<SpriteRenderer>().color = Color.green;
        if (side == "home")
        {
            if (PlayerPrefs.GetString("teamname") == "waves")
            {
                teamWavesHome.SetActive(true);
                teamKnightsAway.SetActive(true);
                float r = 81 / 255;
                float g = 182 / 255;
                pitcher.GetComponent<SpriteRenderer>().color = new Color(r, g, 1, 1);
                batter.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 255);
                power = 5;
                contact = 8;
                velocity = 8;
                control = 6;
                //other team = knights 
                otherteampower = 8;
                otherteamcontact = 5;
                otherteamvelocity = 6;
                otherteamcontrol = 4;
            }
        }
        if (side == "home")
        {
            if (PlayerPrefs.GetString("teamname") == "knights")
            {
                teamKnightsHome.SetActive(true);
                teamWavesAway.SetActive(true);
                float r = 81 / 255;
                float g = 182 / 255;
                pitcher.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 255);
                batter.GetComponent<SpriteRenderer>().color = new Color(r, g, 1, 1);
                power = 8;
                contact = 5;
                velocity = 6;
                control = 4;
                //other team = waves 
                otherteampower = 5;
                otherteamcontact = 8;
                otherteamvelocity = 8;
                otherteamcontrol = 6;
            }
        }
        if (side == "away")
        {
            if (PlayerPrefs.GetString("teamname") == "knights")
            {
                teamKnightsAway.SetActive(true);
                teamWavesHome.SetActive(true);
                float r = 81 / 255;
                float g = 182 / 255;
                batter.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 255);
                pitcher.GetComponent<SpriteRenderer>().color = new Color(r, g, 1, 1);
                power = 8;
                contact = 5;
                velocity = 6;
                control = 4;
                //other team = waves 
                otherteampower = 5;
                otherteamcontact = 8;
                otherteamvelocity = 8;
                otherteamcontrol = 6;
            }
        }
        if (side == "away")
        {
            if (PlayerPrefs.GetString("teamname") == "waves")
            {
                teamWavesAway.SetActive(true);
                teamKnightsHome.SetActive(true);
                float r = 81 / 255;
                float g = 182 / 255;
                //float b = 250 / 255;
                batter.GetComponent<SpriteRenderer>().color = new Color(r, g, 1, 1);
                pitcher.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 255);
                power = 5;
                contact = 10;
                velocity = 8;
                control = 10;
                //other team = knights 
                otherteampower = 8;
                otherteamcontact = 10;
                otherteamvelocity = 5;
                otherteamcontrol = 5;
            }
        }
        float fillCalc = 0;
        if (side == "home")
        {
            fillCalc = control / otherteamcontact;
        }
        else
        {
            fillCalc = otherteamcontrol / contact;
        }
        redPitchingChance.GetComponent<Image>().fillAmount = fillCalc;
    }

    void Update()
    {
        
    }
}