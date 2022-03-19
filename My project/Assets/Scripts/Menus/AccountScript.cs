using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AccountScript : MonoBehaviour
{
    public void SubmitButton()
    {
        SceneManager.LoadScene(2);
    }

    public void GoBack()
    {
        SceneManager.LoadScene(2);
    }

    public void LogOut()
    {
        SceneManager.LoadScene(0);
    }
}
