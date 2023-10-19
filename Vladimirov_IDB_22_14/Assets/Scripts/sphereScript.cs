using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class sphereScript : MonoBehaviour
{
    public Rigidbody body;
    public int speed = 10;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -20)
            Destroy(gameObject);

        if (Input.GetKey(KeyCode.W))
            body.AddForce(new Vector3(0, 0, speed * Time.deltaTime));
        if (Input.GetKey(KeyCode.A))
            body.AddForce(new Vector3(-speed * Time.deltaTime, 0, 0));
        if (Input.GetKey(KeyCode.S))
            body.AddForce(new Vector3(0, 0, -speed * Time.deltaTime));
        if (Input.GetKey(KeyCode.D))
            body.AddForce(new Vector3(speed * Time.deltaTime, 0, 0));

    }

    void Start()
    {
        body = gameObject.GetComponent<Rigidbody>();
    }
}
