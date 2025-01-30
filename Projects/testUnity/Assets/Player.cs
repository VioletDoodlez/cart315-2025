// Used the following tutorial as a source:
// https://medium.com/nerd-for-tech/implementing-a-life-system-unity-e2a9c6b44db5
using System;
using System.Threading;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float xLoc, yLoc = 0;
    public float speed = 1f;
    public static Action OnPlayerHit;
    private int _lives = 3;
    public int Lives { get => _lives; }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
       _lives = 3;
        xLoc = 0;
        yLoc = 0;

        Player.OnPlayerHit += GetHit;
    }

    // Update is called once per frame
    void Update()
    {

         if (Input.GetKey(KeyCode.A)) {
            Debug.Log("Left");
            // update the variable
            xLoc -= speed;

        }
        if (Input.GetKey(KeyCode.D)) {
            Debug.Log("Right");
            // update the variable
            xLoc += speed;
        }

        // Update the position
        this.transform.position = new Vector3(xLoc, yLoc, 0);
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "circle") {
            if (!(OnPlayerHit is null))
            OnPlayerHit();
            Destroy(other.gameObject);
        }
    }

// what happens when the player gets hit
    private void GetHit() {
        _lives--;

        if (_lives < 1) { 
         if (gameObject.tag == "Player") {
            Destroy(gameObject);
        }
        }

        Debug.Log("ow");
    }
}
