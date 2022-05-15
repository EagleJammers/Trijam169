using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptHelper : MonoBehaviour
{
    public GameObject background;
    public void startGame()
    {
        SceneManager.LoadScene("Main Game");
        Object.DontDestroyOnLoad(background);
    }

    public void Die()
    {
        SceneManager.LoadScene("Die");
        Object.DontDestroyOnLoad(background);
    }
}
