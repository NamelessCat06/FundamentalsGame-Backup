using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
    public string Scene;

    public void NextScene()
    {
        SceneManager.LoadScene(Scene);
    }

    public void Quit()
    {
        Debug.Log("Quit the game");
        Application.Quit();
    }
}
