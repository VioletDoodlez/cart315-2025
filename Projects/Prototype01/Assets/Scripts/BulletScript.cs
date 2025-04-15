using UnityEngine;

public class BulletScript : MonoBehaviour
{
    SpriteRenderer bulletSprite;
    private float yPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bulletSprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Wall" || other.gameObject.tag == "Floor")
        {
            Destroy(this.gameObject);
        }

        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }

}
