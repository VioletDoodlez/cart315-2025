using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float xPos, yPos;

    Rigidbody2D playerRigidbody;
    public float playerSpeed = .05f;
    public float jumpSpeed = 10f;
    public float floor, leftWall, rightWall;

    public KeyCode leftKey, rightKey, upKey;

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
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

        if (Input.GetKeyDown(upKey))
        {
            playerRigidbody.AddForce(transform.up * jumpSpeed);
            Debug.Log("hi");

        }

    }
}
