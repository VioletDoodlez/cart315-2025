using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    private float xPos, yPos;
    public float paddleSpeed = .05f;

    public KeyCode upKey, downKey;
    public float topWall, bottomWall, leftWall, rightWall;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "paddleLeft")
        {
            //move down
            if (Input.GetKey(downKey) && yPos > bottomWall)
            {
                yPos -= paddleSpeed;
            }

            //move up
            if (Input.GetKey(upKey) && yPos < topWall)
            {
                yPos += paddleSpeed;
            }
            transform.localPosition = new Vector3(transform.position.x, yPos, 0);
        }

        if (gameObject.name == "paddleRight")
        {
            //move down
            if (Input.GetKey(upKey) && yPos > bottomWall)
            {
                yPos -= paddleSpeed;
            }

            //move up
            if (Input.GetKey(downKey) && yPos < topWall)
            {
                yPos += paddleSpeed;
            }
            transform.localPosition = new Vector3(transform.position.x, yPos, 0);
        }


        if (gameObject.name == "paddleTop")
        {
            //move left
            if (Input.GetKey(KeyCode.A) && xPos > leftWall)
            {
                xPos -= paddleSpeed;
            }

            //move right
            if (Input.GetKey(KeyCode.D) && xPos < rightWall)
            {
                xPos += paddleSpeed;
            }
            transform.localPosition = new Vector3(xPos, transform.position.y, 0);
        }

        if (gameObject.name == "paddleBottom")
        {
            //move left
            if (Input.GetKey(KeyCode.D) && xPos > leftWall)
            {
                xPos -= paddleSpeed;
            }

            //move right
            if (Input.GetKey(KeyCode.A) && xPos < rightWall)
            {
                xPos += paddleSpeed;
            }
            transform.localPosition = new Vector3(xPos, transform.position.y, 0);
        }
    }
}

