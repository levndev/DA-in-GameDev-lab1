using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    public GameObject Cylinder;
    void Update()
    {
        transform.position = new Vector3(1 + Mathf.Sin(Time.timeSinceLevelLoad) * 2, 1);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Cube")
        {
            other.gameObject.GetComponent<Renderer>().material.color = Color.green;
            Debug.Log("Sphere colliding with cube");
            Cylinder.transform.parent = null;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Cube")
        {
            other.gameObject.GetComponent<Renderer>().material.color = Color.red;
            Cylinder.transform.parent = transform;
        }
    }
}
