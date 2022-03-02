using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class safeButton : MonoBehaviour
{
    public GameObject safe;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenSafe(){
        safe.GetComponent<Animator>().SetBool("OpenSafe",true);
        safe.GetComponent<AudioSource>().Play(0);
    }
}
