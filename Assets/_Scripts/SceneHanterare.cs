using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHanterare : MonoBehaviour
{
    public void SceneChanger(string namn)
    {
        SceneManager.LoadScene(namn);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
