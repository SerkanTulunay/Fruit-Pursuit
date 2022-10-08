using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadlyHazards : MonoBehaviour
{
    private Collider2D spikeCollider;
    // Start is called before the first frame update
    void Start()
    {
        spikeCollider = this.GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Checks if the colllision has tag player
        if(collision.CompareTag("Player"))
        {
            //Calls Kill method from playerState script
            //collision.gameObject.GetComponent<PlayerState>().Kill();
            Debug.Log("Player Killed");
        }
    }
}
