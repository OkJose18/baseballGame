using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject OutText;
    public GameObject HitText;
    public GameObject ChangeText;
    public GameObject WinnerScreen;
    public GameObject TieScreen;
    public GameObject KnightsLogo;
    public GameObject WavesLogo;
    public GameObject BackToMainMenu;
    public GameObject firstbase;
    public GameObject secondbase;
    public GameObject thirdbase;
    public GameObject oneOut;
    public GameObject twoOut;
    public GameObject threeOut;
    public GameObject awayscore;
    public GameObject homescore;
    public GameObject batter;
    public GameObject pitcher;
    public GameObject UserTeam;
    public int innings = 1;
    public int awayScore = 0;
    public int homeScore = 0;
    public int outs = 0;
    public string battingTeam = "away";

    // Start is called before the first frame update
    void Start()
    {
        HitText.SetActive(false);
        OutText.SetActive(false);
        ChangeText.SetActive(false);
        WinnerScreen.SetActive(false);
        KnightsLogo.SetActive(false);
        WavesLogo.SetActive(false);
        TieScreen.SetActive(false);
        BackToMainMenu.SetActive(false);
        BatterOut();
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    public void activateHitText()
    {
        HitText.SetActive(true);
    }

    public void activateOutText()
    {
        OutText.SetActive(true);
    }

    public void activateChangeText()
    {
        ChangeText.SetActive(true);
    }

    public void activateWinnerScreen()
    {
        WinnerScreen.SetActive(true);
        BackToMainMenu.SetActive(true);
    }

    public void activateWavesWin()
    {
        WavesLogo.SetActive(true);
    }

    public void activateKnightsWin()
    {
        KnightsLogo.SetActive(true);
    }

    public void activateTieScreen()
    {
        TieScreen.SetActive(true);
        BackToMainMenu.SetActive(true);
    }

    public void RunnerOn()
    {
        Color yellow = new Color(225, 194, 0);
        Image firstBaseColor = firstbase.GetComponent<Image>();
        Image secondBaseColor = secondbase.GetComponent<Image>();
        Image thirdBaseColor = thirdbase.GetComponent<Image>();

        if (firstBaseColor.color == yellow)
        {
            if (secondBaseColor.color == yellow)
            {
                if (thirdBaseColor.color == yellow)
                {
                    RunCounter();
                }
                else
                {
                    thirdBaseColor.color = yellow;
                }
            }
            else
            {
                secondBaseColor.color = yellow;
            }
        }
        else
        {
            firstBaseColor.color = yellow;
        }
    }
    public void BatterOut()
    {
        if (outs == 1)
        {
            oneOut.GetComponent<Image>().color = new Color(255, 0, 0);
        }
        if (outs == 2)
        {
            twoOut.GetComponent<Image>().color = new Color(255, 0, 0);
        }
        if(outs == 3)
        {
            threeOut.GetComponent<Image>().color = new Color(255, 0, 0);
            activateChangeText();
            outs = 0;
            if(battingTeam == "home")
            {
                innings++;
                if (innings == 3)
                {
                    activateWinnerScreen();
                    if(homeScore > awayScore)
                    {
                        activateKnightsWin();
                    }
                    if(awayScore > homeScore)
                    {
                        activateWavesWin();
                    }
                    if(awayScore == homeScore)
                    {
                        activateTieScreen();
                    }
                } 
            }
            ChangeSides();
        }
    }

    public void OutCounter()
    {
        outs += 1;
        BatterOut();
    }

    public void RunCounter()
    {
        if(battingTeam == "away")
        {
            awayScore += 1;
            awayscore.GetComponent<Text>().text = awayScore.ToString();
        }
        if(battingTeam == "home")
        {
            homeScore += 1;
            homescore.GetComponent<Text>().text = homeScore.ToString();
        }
    }

    public void ChangeSides()
    {
        batter.GetComponent<SpriteRenderer>().color = new Color(0, 0, 225);
        pitcher.GetComponent<SpriteRenderer>().color = new Color(78, 150, 245);
        oneOut.GetComponent<Image>().color = new Color(0, 0, 0);
        twoOut.GetComponent<Image>().color = new Color(0, 0, 0);
        threeOut.GetComponent<Image>().color = new Color(0, 0, 0);
        firstbase.GetComponent<Image>().color = new Color(0, 0, 0);
        secondbase.GetComponent<Image>().color = new Color(0, 0, 0);
        thirdbase.GetComponent<Image>().color = new Color(0, 0, 0);
        if (battingTeam == "home")
        {
            battingTeam = "away";
        }
        else if (battingTeam == "away")
        {
            battingTeam = "home";
        }
    }
}