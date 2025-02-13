using UnityEngine;

public class BrickLayer : MonoBehaviour
{
    public GameObject brick;
    public int rows, columns;
    public float bs_h, bs_v;
    public int numBricks;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Lay();
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector3(Random.Range(-.05f, .05f), Random.Range(-.05f, .05f), 0);
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
