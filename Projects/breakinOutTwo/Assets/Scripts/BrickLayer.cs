using System.Collections;
using UnityEngine;

public class BrickLayer : MonoBehaviour
{
    public GameObject brick;
    public int rows, columns;
    public float bs_h, bs_v;
    public int numBricks;
    private bool initialiseMovement = false; //starts movement
    private float timeElapsed = 0;
    private float transitionDuration = 2; //time it takes for layer to complete movement
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Lay();
    }

    // Update is called once per frame
    void Update()
    {
        if (!initialiseMovement && Input.GetKeyDown(KeyCode.Space))
        {
            initialiseMovement = true;
            StartCoroutine(MoveRight());
        }
    }

    private IEnumerator MoveRight()
    {
        timeElapsed = 0;

        while (timeElapsed < transitionDuration)
        {
            float ratio = timeElapsed / transitionDuration;
            gameObject.transform.position = Vector3.Lerp(Vector3.down, Vector3.right, ratio);
            timeElapsed += Time.deltaTime;

            yield return new WaitForEndOfFrame();
        }
        StartCoroutine(MoveLeft());
    }
    private IEnumerator MoveLeft()
    {
        timeElapsed = 0;

        while (timeElapsed < transitionDuration)
        {
            float ratio = timeElapsed / transitionDuration;
            gameObject.transform.position = Vector3.Lerp(Vector3.right, Vector3.left, ratio);
            timeElapsed += Time.deltaTime;

            yield return new WaitForEndOfFrame();
        }
        StartCoroutine(MoveUp());

    }
    private IEnumerator MoveUp()
    {
        timeElapsed = 0;

        while (timeElapsed < transitionDuration)
        {
            float ratio = timeElapsed / transitionDuration;
            gameObject.transform.position = Vector3.Lerp(Vector3.left, Vector3.up, ratio);
            timeElapsed += Time.deltaTime;

            yield return new WaitForEndOfFrame();
        }
        StartCoroutine(MoveDown());

    }
    private IEnumerator MoveDown()
    {
        timeElapsed = 0;

        while (timeElapsed < transitionDuration)
        {
            float ratio = timeElapsed / transitionDuration;
            gameObject.transform.position = Vector3.Lerp(Vector3.up, Vector3.down, ratio);
            timeElapsed += Time.deltaTime;

            yield return new WaitForEndOfFrame();
        }
        StartCoroutine(MoveRight());

    }

    public void Lay()
    {
        for (int i = 0; i < columns; i++)
        {
            for (int j = 0; j <= rows; j++)
            {
                float xPos = -columns + (i * bs_h);
                float yPos = rows - (j * bs_v);

                GameObject go = Instantiate(brick, new Vector3(xPos, yPos, 0), transform.rotation, this.transform);
            }
        }
    }
}
