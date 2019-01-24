using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpelTest : MonoBehaviour
{
    public GameObject options;
    public GameObject mainPause;
    public GameObject pauseMenu;

    private bool paused = false;

    public Text text;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
        mainPause.SetActive(false);
        options.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timer = Time.time;
        text.text = Mathf.Round(timer).ToString(); 
        transform.Rotate(1, 1, 1, Space.World);

        if (Input.GetKeyDown(KeyCode.Escape) && paused == false)
        {
            PauseGame();
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && paused == true)
        {
            Continue();
        }
    }
    public void PauseGame()
    {
        paused = true;
        pauseMenu.SetActive(true);
        mainPause.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Continue()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        mainPause.SetActive(false);
        options.SetActive(false);
        paused = false;
    }
    public void Options()
    {
        options.SetActive(true);
        mainPause.SetActive(false);
    }
    public void MainPaused()
    {
        mainPause.SetActive(true);
        options.SetActive(false);
    }
}
