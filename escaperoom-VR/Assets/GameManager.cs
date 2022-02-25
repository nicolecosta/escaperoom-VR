using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject PasswordPannel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PasswordPannel.GetComponent<PasswordPannel>().passwordIsCorrect){
            print("open door");
        }
    }
}
