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
    public Animator playerAnimator;

    SpriteRenderer playerSprite;
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
        playerAnimator = GetComponent<Animator>();
        playerSprite = GetComponent<SpriteRenderer>();
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

        playerAnimator.SetFloat("pSpeed", 0);

        if (Input.GetKey(leftKey)) //move left
        {
            playerAnimator.SetFloat("pSpeed", Mathf.Abs(playerSpeed));
            GetComponent<ShootScript>().isLeft = true;
            if (xPos > leftWall)
            {
                xPos -= playerSpeed;
                playerSprite.flipX = true;
            }
        }

        if (Input.GetKey(rightKey)) //move right
        {
            playerAnimator.SetFloat("pSpeed", Mathf.Abs(xPos));
            GetComponent<ShootScript>().isLeft = false;
            if (xPos < rightWall)
            {
                xPos += playerSpeed;
                playerSprite.flipX = false;
            }
        }

        transform.localPosition = new Vector3(xPos, transform.position.y, 0);

        if (Input.GetKeyDown(upKey) && isGrounded)
        {
            playerRigidbody.AddForce(Vector2.up * jumpSpeed, ForceMode2D.Impulse);
            Debug.Log("weee!");


            isGrounded = false;

        }

        // if (facingRight)
        // {
        //     Vector3 updateScale = transform.localScale;
        //     updateScale.x = 2;
        //     transform.localScale = updateScale;
        // }
        // else
        // {
        //     Vector3 updateScale = transform.localScale;
        //     updateScale.x = -2;
        //     transform.localScale = updateScale;
        // }

    }

}
