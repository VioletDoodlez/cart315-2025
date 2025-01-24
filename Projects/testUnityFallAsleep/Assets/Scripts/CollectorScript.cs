using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectorScript : MonoBehaviour
{
    public float xLoc, yLoc;
    // Start is called before the first frame update
    void Start()
    {
       xLoc = 0; 
       yLoc = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) {
            xLoc -= 0.1f;
        }
        if (Input.GetKey(KeyCode.D)) {
            xLoc += 0.1f;
        }
            this.transform.position = new Vector3(xLoc, yLoc, 0);

    }

}
