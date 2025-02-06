using System.Collections;
using UnityEngine;

public class ballScript : MonoBehaviour
{
    public float ballSpeed = 2;

    private Rigidbody2D rb;
    private int hDir, vDir;
    private int[] directions = { -1, 1 };
    public int score1, score2;
    public AudioSource blip;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        StartCoroutine(Launch());
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D wall)
    {
        if (wall.gameObject.name == "leftWall")
        {
            //pts P2
            score2 += 1;
            Reset();
        }
        if (wall.gameObject.name == "rightWall")
        {
            //pts P1
            score1 += 1;
            Reset();
        }

        if (wall.gameObject.name == "bottomWall" || wall.gameObject.name == "topWall")
        {
            blip.pitch = 0.75f;
            blip.Play();
        }

        if (wall.gameObject.name == "paddleLeft" || wall.gameObject.name == "paddleRight")
        {
            blip.pitch = 1f;
            blip.Play();
        }
    }

    private IEnumerator Launch()
    {
        //choose random X dir
        hDir = directions[Random.Range(0, directions.Length)];
        //choose random Y dir
        vDir = directions[Random.Range(0, directions.Length)];
        Random.Range(0, directions.Length);
        //wait for x seconds
        yield return new WaitForSeconds(1);
        //spply force
        rb.AddForce(transform.right * ballSpeed * hDir);
        rb.AddForce(transform.up * ballSpeed * vDir);
        //launch
    }

    void Reset()
    {
        rb.linearVelocity = Vector2.zero;
        this.transform.localPosition = new Vector3(0, 0, 0);
        //reset 0,0
        //launch
        StartCoroutine(Launch());
    }
}
