using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject door;
    public GameObject PasswordPannel;
    public List<GameObject> keyObjectsList;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(PasswordPannel.GetComponent<PasswordPannel>().passwordIsCorrect){
            door.GetComponent<Animator>().SetBool("openDoor",true);
            door.GetComponent<AudioSource>().Play(0);
        }
    }
}
