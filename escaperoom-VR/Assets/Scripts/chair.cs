using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chair : MonoBehaviour
{
    public GameObject movingPlane;
    void Start()
    {
        movingPlane = transform.GetChild(0).gameObject;
        movingPlane.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        print(transform.eulerAngles);
        if(transform.rotation.eulerAngles.x == 0.0f && transform.rotation.eulerAngles.z == 0.0f){
            movingPlane.gameObject.SetActive(true);
        }
        else{
            movingPlane.gameObject.SetActive(false);
        }
    }
}
