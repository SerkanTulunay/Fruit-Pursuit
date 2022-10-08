using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheckpoint : MonoBehaviour
{
    //Sätt detta på checkpoint objektet!!!
    //Checkpoint Objektet måste ha en Box Collider 2D med "Trigger" på.

    [SerializeField] private Sprite checkPointTaken;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") == true)
        {
            collision.GetComponent<PlayerState>().ChangeRespawnPosition(gameObject);
            gameObject.GetComponent<SpriteRenderer>().sprite = checkPointTaken;
        }
    }

    //Lägg till detta i Melvins Playerstate (Inte detta script):
    //[SerializeField] private GameObject respawnPosition;
    //public void Respawn(){
    //gameObject.transform.position = respawnPosition.transform.position;
//}
    // public void ChangeRespawnPosition(GameObject newRespawnPosition){
   // respawnPosition = newRespawnPosition;
//}
}
