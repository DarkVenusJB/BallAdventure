using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    [SerializeField] private GameStats stats;

    private void OnTriggerEnter(Collider other)
    {
        stats.coins++;
        Destroy(gameObject);
    }
}
