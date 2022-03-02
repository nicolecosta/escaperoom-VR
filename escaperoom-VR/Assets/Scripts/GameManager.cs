using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject door;
    public GameObject PasswordPannel;
    public int phases;
    void Start()
    {
        phases = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(PasswordPannel.GetComponent<PasswordPannel>().passwordIsCorrect){
            print("open door");
            //play sound
            door.GetComponent<Animator>().SetBool("openDoor",true);
            door.GetComponent<AudioSource>().Play(0);
        }
    }
}
