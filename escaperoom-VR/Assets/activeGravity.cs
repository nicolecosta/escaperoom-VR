using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activeGravity : MonoBehaviour
{
    public Rigidbody Rigidbody;

    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision != null){
            Rigidbody.useGravity = true;
        }
    }


}
