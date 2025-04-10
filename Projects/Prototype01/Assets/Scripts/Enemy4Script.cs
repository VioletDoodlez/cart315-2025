using System.Collections;
using UnityEngine;

public class Enemy4Script : MonoBehaviour
{
    private bool initialiseMovement = false; //starts movement
    private float timeElapsed = 0;
    private float transitionDuration = 4; //time it takes for layer to complete movement

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

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
            gameObject.transform.position = Vector3.Lerp(new Vector3(45f, 1f, 0f), new Vector3(50f, 1f, 0f), ratio);
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
            gameObject.transform.position = Vector3.Lerp(new Vector3(50f, 1f, 0f), new Vector3(45f, 1f, 0f), ratio);
            timeElapsed += Time.deltaTime;

            yield return new WaitForEndOfFrame();
        }
        StartCoroutine(MoveRight());

    }
}