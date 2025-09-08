using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSetting : MonoBehaviour
{
   
    public void Play()
    {
        SceneManager.LoadScene("Characterselect");
    }
    public void characterslect()
    {
        SceneManager.LoadScene(0);
    }
    public void Setting()
    {
        SceneManager.LoadScene("Settings");
    }

    public void Extras()
    {
        SceneManager.LoadScene("Extras");
    }
    public void Exit()
    {
        Application.Quit();
    }

    public void ExitMenu()
    {
        SceneManager.LoadScene(8);

    }
    public void login()
    {
        SceneManager.LoadScene(2);

    }
}


