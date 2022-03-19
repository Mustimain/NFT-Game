using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterChoose : MonoBehaviour
{
    [SerializeField]
    private GameObject[] characters;


    public void SelectCharacter()
    {
        SceneManager.LoadScene(5);
    }


    public void GoBackButton()
    {
        SceneManager.LoadScene(2);
    }


    public void ChangeCharacter(int index)
    {

        for (int i = 0; i < characters.Length; i++)
        {
            characters[i].SetActive(false);
        }

        characters[index].SetActive(true);

    }


}
