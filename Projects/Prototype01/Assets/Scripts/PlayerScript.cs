using System;
using System.Collections;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float xPos;

    Rigidbody2D playerRigidbody;
    public float playerSpeed = 10f;
    public static Action OnPlayerHit;
    private int lives = 3;
    public int Lives { get => lives; }
    public bool isGrounded;
    public bool facingRight = true;
    public float jumpSpeed = 400f;
    public float leftWall, rightWall;

    public KeyCode leftKey, rightKey, upKey;

    void Start()
    {
        lives = 3;

        playerRigidbody = GetComponent<Rigidbody2D>();
        PlayerScript.OnPlayerHit += GetHit;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Floor")
        {
            isGrounded = true;
        }

        if (other.gameObject.tag == "Enemy")
        {
            if (!(OnPlayerHit is null))
            {
                OnPlayerHit();
            }
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Health")
        {
            if (lives < 3)
            {
                Heal();
                Destroy(other.gameObject);

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
        lives--;

        if (lives < 1)
        {
            // if (gameObject.tag == "Player")
            // {
            //     Destroy(gameObject);
            // }
            Debug.Log("dead");
            StartCoroutine(GameOver());
        }

        Debug.Log("ow");
    }

    private void Heal()
    {
        lives++;

        Debug.Log("aaah");
    }

    public IEnumerator GameOver()
    {
        GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("GameOverScene");
    }

    // Update is called once per frame
    void Update()
    {
        xPos = transform.position.x;

        if (Input.GetKey(leftKey)) //move left
        {
            GetComponent<ShootScript>().isLeft = true;
            if (xPos > leftWall)
            {
                xPos -= playerSpeed;
                facingRight = false;
            }
        }

        if (Input.GetKey(rightKey)) //move right
        {
            GetComponent<ShootScript>().isLeft = false;
            if (xPos < rightWall)
            {
                xPos += playerSpeed;
                facingRight = true;
            }
        }

        transform.localPosition = new Vector3(xPos, transform.position.y, 0);

        if (Input.GetKeyDown(upKey) && isGrounded)
        {
            playerRigidbody.AddForce(Vector2.up * jumpSpeed, ForceMode2D.Impulse);
            Debug.Log("weee!");


            isGrounded = false;

        }

        if (facingRight)
        {
            Vector3 updateScale = transform.localScale;
            updateScale.x = 2;
            transform.localScale = updateScale;
        }
        else
        {
            Vector3 updateScale = transform.localScale;
            updateScale.x = -2;
            transform.localScale = updateScale;
        }

    }

}
