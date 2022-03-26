using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public TMP_Text scoreUI;
    public Character character;

    private void Update()
    {
        scoreUI.text = "Score: " + character.score.ToString();
    }

    private void Start()
    {
        gameObject.SetActive(false);
    }

    public void ScoreText(int score)
    {
        gameObject.SetActive(true);
    }

    public void RestarButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ExitButton()
    {
        SceneManager.LoadScene(2);
    }


}
