using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brainScript : MonoBehaviour
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
        transform.eulerAngles = new Vector3(this.transform.eulerAngles.x, yRotation * 0.05f , this.transform.eulerAngles.z);
        this.transform.position = new Vector3(this.transform.position.x,this.transform.position.y,this.transform.position.z + Time.deltaTime * 5);
    }
}
