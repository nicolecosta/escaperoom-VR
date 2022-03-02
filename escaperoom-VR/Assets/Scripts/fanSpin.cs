using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fanSpin : MonoBehaviour
{
    float yRotation;
    float t = 0.0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        yRotation = 360 * t;
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, yRotation, transform.eulerAngles.z);
    }

}
