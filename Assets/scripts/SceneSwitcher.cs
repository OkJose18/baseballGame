using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneSwitcher : MonoBehaviour
{
    public GameObject cursor;

    public void Start()
    {
    }

    public void TeamSelect()
    {
        if(cursor.GetComponent<cursormovement>().team == "Home")
        {
            SceneManager.LoadScene("away");
        }

        if(cursor.GetComponent<cursormovement>().team == "Away")
        {
            Debug.Log("start game");
            SceneManager.LoadScene("away");
        }
    }

    public void TestRoom()
    {
        SceneManager.LoadScene("team select");    
    }

    public void Back()
    {
        SceneManager.LoadScene("title screen");
    }

    public void Quit()  
    {
        SceneManager.LoadScene("title screen");
        Debug.Log("back to main menu");
    }

    public void quit()
    {
        SceneManager.LoadScene("title screen");
    }
}
