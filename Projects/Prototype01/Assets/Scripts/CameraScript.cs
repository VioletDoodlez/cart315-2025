using System.Collections;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public float cameraSpeed = 0.5f;
    public float yOffset = 2f;
    public Transform player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = new Vector3(player.position.x, player.position.y + yOffset, -10f);
        transform.position = Vector3.Slerp(transform.position, newPos, cameraSpeed * Time.deltaTime);
    }
}
