using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float xPos;

    Rigidbody2D playerRigidbody;
    public float playerSpeed = 10f;
    public bool isGrounded;
    public float jumpSpeed = 400f;
    public float floor, leftWall, rightWall;

    public KeyCode leftKey, rightKey, upKey;

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            isGrounded = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        xPos = transform.position.x;

        if (Input.GetKey(leftKey))
        {
            if (xPos > leftWall)
            {
                xPos -= playerSpeed;
            }
        }

        if (Input.GetKey(rightKey))
        {
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
