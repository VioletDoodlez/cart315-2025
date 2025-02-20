using System.Collections;
using UnityEngine;

public class BrickLayer : MonoBehaviour
{
    public GameObject brick;
    public int rows, columns;
    public float bs_h, bs_v;
    public int numBricks;
    private float timeElapsed = 0;
    private float transitionDuration = 2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Lay();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) { StartCoroutine(MoveRight()); }
    }

    private IEnumerator MoveRight()
    {
        while (timeElapsed < transitionDuration)
        {
            float ratio = timeElapsed / transitionDuration;
            gameObject.transform.position = Vector3.Lerp(Vector3.left, Vector3.right, ratio);
            timeElapsed += Time.deltaTime;

            yield return MoveLeft();
        }
    }
    private IEnumerator MoveLeft()
    {
        while (timeElapsed < transitionDuration)
        {
            float ratio = timeElapsed / transitionDuration;
            gameObject.transform.position = Vector3.Lerp(Vector3.right, Vector3.left, ratio);
            timeElapsed += Time.deltaTime;

            yield return new WaitForEndOfFrame();
        }
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
