using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPos;
    [SerializeField] private Rigidbody playerRb;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.position = respawnPos.position;
            playerRb.velocity = Vector3.zero;
        }
    }
}
