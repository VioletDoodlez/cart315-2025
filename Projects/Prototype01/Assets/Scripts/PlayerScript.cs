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
    public static Action OnPlayerHeal;
    private int lives = 3;
    public int Lives { get => lives; }
    public bool isGrounded;
    public float jumpSpeed = 400f;
    public float leftWall, rightWall;

    public KeyCode leftKey, rightKey, upKey;

    void Start()
    {
        lives = 3;

        playerRigidbody = GetComponent<Rigidbody2D>();
        PlayerScript.OnPlayerHit += GetHit;
        PlayerScript.OnPlayerHeal += GetHealth;
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
        if (other.gameObject.tag == "Health")
        {
            if (!(OnPlayerHeal is null))
            {
                OnPlayerHeal();
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

    private void GetHealth()
    {

        if (lives < 3)
        {
            lives++;

            if (gameObject.tag == "Health")
            {
                Destroy(gameObject);
            }
        }

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
