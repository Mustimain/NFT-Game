using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RegisterScript : MonoBehaviour
{
    public void Create()
    {
        SceneManager.LoadScene(0);
    }

    public void GoBack()
    {
        SceneManager.LoadScene(0);
    }
}
