using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MUI : MonoBehaviour
{
    [SerializeField] private GameObject levels;
    [SerializeField] private GameStats stats;
    [SerializeField] private Button button2;
    [SerializeField] private Button button3;

    private void Start()
    {

        SaveLoadManager.instance.LoadGame();
        
    }
    public void ExitButton()
    {
        SaveLoadManager.instance.SaveGame();
        Application.Quit();
        
    }


    public void LevelButton()
    {
        levels.SetActive(true);
        
        switch(stats.completedLevels)
        {
            case 1:
                button2.interactable = true;
                break;
            case 2:
                button2.interactable= true;
                button3.interactable = true;
                break;
        }
    }

    public void FirstPlayButton ()
    {
        SceneManager.LoadScene(1);
    }

    public void SecondPlayButton ()
    {
        SceneManager.LoadScene(2);
    }

    public void ThirdPlayButton ()
    {
        SceneManager.LoadScene(3);
    }
}
