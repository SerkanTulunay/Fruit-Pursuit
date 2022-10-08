using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour
{
    public int coinAmount = 0;

    private void Start()
    {
        Respawn();
    }

    public void CoinPickup()
    {
        coinAmount++;
    }

    [SerializeField] private GameObject respawnPosition;
    public void Respawn(){
    gameObject.transform.position = respawnPosition.transform.position;
    }
    public void ChangeRespawnPosition(GameObject newRespawnPosition){
    respawnPosition = newRespawnPosition;
    }
}
