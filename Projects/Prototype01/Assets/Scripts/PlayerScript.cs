using System;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float xPos;

    Rigidbody2D playerRigidbody;
    public float playerSpeed = 10f;
    public static Action OnPlayerHit;
    private int _lives = 3;
    public int Lives { get => _lives; }
    public bool isGrounded;
    public float jumpSpeed = 400f;
    public float floor, leftWall, rightWall;

    public KeyCode leftKey, rightKey, upKey;

    void Start()
    {
        _lives = 3;

        playerRigidbody = GetComponent<Rigidbody2D>();
        PlayerScript.OnPlayerHit += GetHit;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            isGrounded = true;
        }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            if (!(OnPlayerHit is null))
            {
                OnPlayerHit();
            }

        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            isGrounded = false;
        }
    }
    private void GetHit()
    {
        _lives--;

        if (_lives < 1)
        {
            if (gameObject.tag == "Player")
            {
                Destroy(gameObject);
            }
        }

        Debug.Log("ow");
    }

    // Update is called once per frame
    void Update()
    {
        xPos = transform.position.x;

        if (Input.GetKey(leftKey))
        {
            GetComponent<ShootScript>().isLeft = true;
            if (xPos > leftWall)
            {
                xPos -= playerSpeed;
            }
        }

        if (Input.GetKey(rightKey))
        {
            GetComponent<ShootScript>().isLeft = false;
            if (xPos < rightWall)
            {
                xPos += playerSpeed;
            }
        }

        transform.localPosition = new Vector3(xPos, transform.position.y, 0);

        if (Input.GetKeyDown(upKey) && isGrounded)
        {
            playerRigidbody.AddForce(Vector2.up * jumpSpeed, ForceMode2D.Impulse);
            Debug.Log("weee!");


            isGrounded = false;

        }

    }

}
