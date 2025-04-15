using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public GameObject shot;
    public Animator playerAnimator;
    public float shotSpeed = 10;
    public KeyCode fireButton;
    public bool isLeft;
    public GameObject shotLocationR, shotLocationL;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(fireButton))
        {
            Fire();
            playerAnimator.SetBool("isShooting", true);
        }
        else
        {
            playerAnimator.SetBool("isShooting", false);
        }
    }

    public void Fire()
    {
        if (isLeft)
        {
            GameObject go = Instantiate<GameObject>(shot);
            go.transform.position = shotLocationL.transform.position;
            //go.GetComponent<SpriteRenderer>().
            Rigidbody2D rb = go.GetComponent<Rigidbody2D>();
            rb.linearVelocityX = -shotSpeed;

        }
        else
        {
            GameObject go = Instantiate<GameObject>(shot);
            go.transform.position = shotLocationR.transform.position;
            Rigidbody2D rb = go.GetComponent<Rigidbody2D>();
            rb.linearVelocityX = shotSpeed;

        }
    }
}
