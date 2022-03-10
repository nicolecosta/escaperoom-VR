using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chair : MonoBehaviour
{
    public GameObject movingPlane;
    private Vector3 angulo;
    void Start()
    {
        movingPlane = transform.GetChild(0).gameObject;
        movingPlane.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        angulo = new Vector3(0,transform.rotation.eulerAngles.y,0);

        if(transform.rotation.eulerAngles.x < 0.05 && transform.rotation.eulerAngles.x > -0.05 && transform.rotation.eulerAngles.z < 0.05 && transform.rotation.eulerAngles.z > -0.05){
            movingPlane.gameObject.SetActive(true);
        }
        else{
            movingPlane.gameObject.SetActive(false);
        }
    }
}
