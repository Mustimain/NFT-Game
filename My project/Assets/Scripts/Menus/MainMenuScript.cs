using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenuScript : MonoBehaviour
{
    public TMP_Text text;
    public Character character;

    private void Update()
    {
        text.text = character.totalScore.ToString();
    }


    public void OpenStoreButton()
    {
        
    }

    public void OpenAccountDetail()
    {
        SceneManager.LoadScene(4);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void PlayButton()
    {
        SceneManager.LoadScene(3);
    }
}
