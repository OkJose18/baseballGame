using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class FadeBlack : MonoBehaviour
{
    public GameObject fadeInImage;
    public GameObject gamemanager;
    public float alpha = 1;
    public float speed = .03f;
    public float timer = 0;
    public bool fadeOut = false;
    public bool titleScreen = false;
    public bool teamSelect = false;
    public bool away = false;

    // Start is called before the first frame update
    void Start()
    {
        fadeInImage.GetComponent<Image>().color = new Color(0, 0, 0, alpha);
        fadeIn();
    }

    // Update is called once per frame
    void Update()
    {
        if (fadeOut == false)
        {
            fadeIn();
        }
        else
        {
            FadeOut();
        }
    }

    public void fadeIn()
    {
        if (alpha > 0.1)
        {
            timer += Time.deltaTime;
        }
        alpha -= speed;
        fadeInImage.GetComponent<Image>().color = new Color(0, 0, 0, alpha);
        if (alpha < 0.1f)
        {
            fadeInImage.SetActive(false);
        }
    }

    public void FadeOut()
    {
        if (fadeOut == true)
        {
            alpha += speed;
            fadeInImage.GetComponent<Image>().color = new Color(0, 0, 0, alpha);
            if (alpha > 0.95)
            {
                if (teamSelect)
                {
                    gamemanager.GetComponent<SceneSwitcher>().TestRoom();
                }
                else if (titleScreen)
                {
                    gamemanager.GetComponent<SceneSwitcher>().Back();
                }
                else if (away)
                {
                    gamemanager.GetComponent<SceneSwitcher>().TeamSelect();
                }
                
            }
        }  
    }

    public void TeamSelect()
    {
        teamSelect = true;
        fadeInImage.SetActive(true);
        fadeOut = true;
    }

    public void Away()
    {
        away = true;
        fadeInImage.SetActive(true);
        fadeOut = true;
    }

    public void TitleScreen()
    {
        titleScreen = true;
        fadeInImage.SetActive(true);
        fadeOut = true;
    }
}
