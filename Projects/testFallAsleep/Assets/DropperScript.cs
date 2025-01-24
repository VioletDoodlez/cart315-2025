using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropperScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(routine:Drop());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Drop() {
        Debug.Log("drop");
    }
}
