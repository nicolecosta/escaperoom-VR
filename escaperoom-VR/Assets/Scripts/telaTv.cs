using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class telaTv : MonoBehaviour
{
    public Renderer thisRenderer;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void redColor(){
        thisRenderer.material.color = Color.red;
    }

    public void greenColor(){
        thisRenderer.material.color = Color.green;
    }

    public void yellowColor(){
        thisRenderer.material.color = Color.yellow;
    }

    public void blueColor(){
        thisRenderer.material.color = Color.blue;
    }

    public void whiteColor(){
        thisRenderer.material.color = Color.white;
    }

    public void pinkColor(){
        thisRenderer.material.color = new Color(1f, 0.2f, 0.4f, 0.3f);
    }
}
