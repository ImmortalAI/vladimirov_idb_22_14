using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class test_script : MonoBehaviour
{
    public TMP_Text textObject;
    public int clicks = 0;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(16 * Time.deltaTime, 8 * Time.deltaTime, 4 * Time.deltaTime);
    }

    public void onClick()
    {
        MeshRenderer mesh = gameObject.GetComponent<MeshRenderer>();

        mesh.enabled = !(mesh.enabled);

        textObject.text = (++clicks).ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        textObject.text = (--clicks).ToString();
    }
}
