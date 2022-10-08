using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFly : MonoBehaviour
{
    private Collider2D flyCollider;
    private Rigidbody2D rb;
    [SerializeField] private GameObject player;
    private float playerYPos;
    [SerializeField] private float flySpeed;
    Vector2 posOffset = new Vector2();
    // Start is called before the first frame update
    void Start()
    {
        flyCollider = gameObject.GetComponent<Collider2D>();
        rb = gameObject.GetComponent<Rigidbody2D>();
        posOffset = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Update player's Y position
        playerYPos = player.transform.position.y;
        moveUpAndDown();
        Debug.Log(flySpeed);
    }

    //Fly moving up and down depending on the difference between player's and the fly's y position
    private void moveUpAndDown()
    {
        if(transform.position.y < playerYPos - 3)
        {

            flySpeed -= 1f;
        }
        else if(gameObject.transform.position.y > playerYPos + 3)
        {
            flySpeed += 1f;
        }

        if (flySpeed > 5)
        {
            flySpeed = 5;
        }
        else if(flySpeed < -5)
        {
            flySpeed = -5;
        }

        transform.Translate(Vector2.down * Time.fixedDeltaTime * flySpeed);
    }
}
