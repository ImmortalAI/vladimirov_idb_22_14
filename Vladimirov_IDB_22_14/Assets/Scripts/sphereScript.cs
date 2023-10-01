using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class sphereScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -20)
            Destroy(gameObject);
    }
}
