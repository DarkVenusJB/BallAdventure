using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [SerializeField] private GameObject pauseImage;

    private int index;
    private void Awake()
    {
        index = SceneManager.GetActiveScene().buildIndex;
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }

 
    public void NextLvlButton()
    {
        SceneManager.LoadScene(index + 1);
    }
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseImage.SetActive(true);
            Time.timeScale = 0;
        }
    }
    public void MenuButton()
    {
        SceneManager.LoadScene(0);
    }
    public void Restart()
    {
        SceneManager.LoadScene(index);
    }
    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }


    public void Resume()
    {
        pauseImage.SetActive(false);
        Time.timeScale = 1;
    }

}
