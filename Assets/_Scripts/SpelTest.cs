using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpelTest : MonoBehaviour
{
    public GameObject pauseMenu;
    private bool paused = false;
    public Text text;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);   
    }

    // Update is called once per frame
    void Update()
    {
        timer = Time.time;
        text.text = Mathf.Round(timer).ToString(); 
        transform.Rotate(1, 1, 1, Space.World);

        if (Input.GetKeyDown(KeyCode.Escape) && paused == false)
        {
            Time.timeScale = 0f;
            PauseGame();
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && paused == true)
        {
            Continue();
            Time.timeScale = 1f;
        }
    }
    private void PauseGame()
    {
        paused = true;
        pauseMenu.SetActive(true);
    }
    private void Continue()
    {
        pauseMenu.SetActive(false);
        paused = false;
    }
}
