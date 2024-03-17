using UnityEngine;

[CreateAssetMenu]

public class GameStats : ScriptableObject
{
     [SerializeField] private int _coin;
    [SerializeField] private int _completedLevels;
    public int coins
    {
        get
        {
            return _coin;
        }
        set
        {
            _coin = value;
        }
    }
    public int completedLevels
    {
        get
        {
            return _completedLevels;
        }
        set 
        {
            if (value <= 2) 
                _completedLevels = value;
            else
            {
                _completedLevels = 2;
            }
        } 
    }
}
