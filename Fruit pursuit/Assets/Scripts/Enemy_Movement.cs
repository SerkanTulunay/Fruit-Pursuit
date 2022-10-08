using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Movement : MonoBehaviour
{

    public float speed = 5f;
    private float movementDirection = 1f;

    Rigidbody2D rigidBody2D;

    bool isGrounded;

    public GameObject groundCheck;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 newPosition = gameObject.transform.position;
        newPosition.x += speed * Time.deltaTime * movementDirection;
        rigidBody2D.MovePosition(newPosition);

        CheckForGround();

        if(isGrounded == false)
        {
            ChangeDirection();
        }
    }

    private void CheckForGround()
    {
        isGrounded = false;

        Collider2D[] colliders = Physics2D.OverlapCircleAll(groundCheck.transform.position, 0.2f);

        for (int i = 0; i < colliders.Length; i++)
        {
            if (colliders[i].gameObject != gameObject)
            {
                isGrounded = true;
            }
        }
    }

    private void ChangeDirection()
    {
        movementDirection = -movementDirection;
        Vector3 newScale = gameObject.transform.localScale;
        newScale.x = movementDirection * newScale.x;
        gameObject.transform.localScale = newScale;
    }
}
