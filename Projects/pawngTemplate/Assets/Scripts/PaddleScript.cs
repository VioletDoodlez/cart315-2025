using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour {
    private float     xPos, yPos;
    public float      paddleSpeed = .05f;

    public KeyCode upKey, downKey;
    public float topWall, bottomWall, leftWall, rightWall;
	
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (gameObject.name == "paddleLeft") {
        if (Input.GetKey(downKey) && yPos > bottomWall) {
            yPos -= paddleSpeed;
        }

        if (Input.GetKey(upKey)&& yPos < topWall) {
            yPos += paddleSpeed;
        }
        }

        if (gameObject.name == "paddleRight") {
        if (Input.GetKey(upKey) && yPos > bottomWall) {
            yPos -= paddleSpeed;
        }

        if (Input.GetKey(downKey)&& yPos < topWall) {
            yPos += paddleSpeed;
        }
        }

        if (gameObject.name == "paddleTop") {
        if (Input.GetKey(downKey) && xPos > leftWall) {
            xPos -= paddleSpeed;
        }

        if (Input.GetKey(upKey)&& xPos < rightWall) {
            xPos += paddleSpeed;
        }
        }

        if (gameObject.name == "paddleBottom") {
        if (Input.GetKey(downKey) && xPos > leftWall) {
            xPos -= paddleSpeed;
        }

        if (Input.GetKey(upKey)&& xPos < rightWall) {
            xPos += paddleSpeed;
        }
        }

        transform.localPosition = new Vector3(transform.position.x, yPos, 0);
    }
}

