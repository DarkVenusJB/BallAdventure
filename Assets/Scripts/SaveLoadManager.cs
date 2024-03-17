using JetBrains.Annotations;
using UnityEngine;


public class SaveLoadManager : MonoBehaviour
{
    [SerializeField] private GameStats gameStats;
    private string coinsKey = "Save coins";
    private string levelsKey = "Save levels";
    
 

    public static SaveLoadManager instance {  get; private set; }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            return;
        }
        Destroy(this.gameObject);

    }
    private void Start()
    {
        
    }
    public void SaveGame()
    {
        PlayerPrefs.SetInt(coinsKey, gameStats.coins);
        PlayerPrefs.SetInt(levelsKey, gameStats.completedLevels);
        Debug.Log("Game Saved");
    }
    public void LoadGame()
    {
        if(PlayerPrefs.HasKey(coinsKey))
        {
            gameStats.coins = PlayerPrefs.GetInt(coinsKey);
        }
        if (PlayerPrefs.HasKey(levelsKey))
        {
            gameStats.completedLevels = PlayerPrefs.GetInt (levelsKey);
        }
        Debug.Log("game loaded");
    }
   


}
