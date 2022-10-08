using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheckpoint : MonoBehaviour
{
    //S�tt detta p� checkpoint objektet!!!
    //Checkpoint Objektet m�ste ha en Box Collider 2D med "Trigger" p�.

    [SerializeField] private Sprite checkPointTaken;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") == true)
        {
            collision.GetComponent<PlayerState>().ChangeRespawnPosition(gameObject);
            gameObject.GetComponent<SpriteRenderer>().sprite = checkPointTaken;
        }
    }

    //L�gg till detta i Melvins Playerstate (Inte detta script):
    //[SerializeField] private GameObject respawnPosition;
    //public void Respawn(){
    //gameObject.transform.position = respawnPosition.transform.position;
//}
    // public void ChangeRespawnPosition(GameObject newRespawnPosition){
   // respawnPosition = newRespawnPosition;
//}
}
