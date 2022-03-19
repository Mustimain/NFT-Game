using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginScript : MonoBehaviour
{
    
    public void CreateAccountButton()
    {
        SceneManager.LoadScene(1);
    }

    public void Login()
    {
        SceneManager.LoadScene(2);
    }
}
