using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPositionScript : MonoBehaviour
{
    
    void Start()
    {
        if(SceneManager.GetActiveScene().buildIndex != 1){
            transform.position = new Vector3 (0,0,0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
