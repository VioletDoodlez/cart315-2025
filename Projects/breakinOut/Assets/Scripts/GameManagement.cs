using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
{
    public int points;
    public int lives;
    public static GameManagement S;

    void Awake()
    {
        S = this;
    }

    public void LoseLife()
    {
        lives -= 1;
        Debug.Log(lives);

        if (lives <= 0)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void AddPoint(int pointValue)
    {
        points += pointValue;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }


}
