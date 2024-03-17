using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{

    [SerializeField] GameObject finishMenu;
    [SerializeField] GameStats gameStats;

    private void Awake()
    {
        Time.timeScale = 1.0f;
    }

    private void OnTriggerEnter(Collider other)
    {
        int index = SceneManager.GetActiveScene().buildIndex;
        gameStats.completedLevels = index;
        Time.timeScale = 0;
        finishMenu.SetActive(true);
    }
}
