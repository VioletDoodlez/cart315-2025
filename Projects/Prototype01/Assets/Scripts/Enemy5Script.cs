using System.Collections;
using UnityEngine;

public class Enemy5Script : MonoBehaviour
{
    SpriteRenderer enemySprite;
    private bool initialiseMovement = false; //starts movement
    private float timeElapsed = 0;
    private float transitionDuration = 4; //time it takes for layer to complete movement

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enemySprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        if (!initialiseMovement)
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
            gameObject.transform.position = Vector3.Lerp(new Vector3(46.5f, 14.8f, 0f), new Vector3(53f, 14.8f, 0f), ratio);
            timeElapsed += Time.deltaTime;
            enemySprite.flipX = true;

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
            gameObject.transform.position = Vector3.Lerp(new Vector3(53f, 14.8f, 0f), new Vector3(46.5f, 14.8f, 0f), ratio);
            timeElapsed += Time.deltaTime;
            enemySprite.flipX = false;

            yield return new WaitForEndOfFrame();
        }
        StartCoroutine(MoveRight());

    }
}
