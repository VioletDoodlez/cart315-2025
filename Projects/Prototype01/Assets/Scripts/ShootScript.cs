using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public GameObject shot;
    public float shotSpeed = 10;
    public KeyCode fireButton;
    public bool isLeft;
    public GameObject shotLocationR, shotLocationL;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(fireButton)) Fire();
    }

    public void Fire()
    {
        if (isLeft)
        {
            GameObject go = Instantiate<GameObject>(shot);
            go.transform.position = shotLocationR.transform.position;
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
