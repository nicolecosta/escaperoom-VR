using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class GameManager : MonoBehaviour
{
    public GameObject door;
    public GameObject PasswordPannel;
    public List<GameObject> keyObjectsList;
    public GameObject teleportPoint;
    void Start()
    {
        teleportPoint.GetComponent<TeleportMarkerBase>().markerActive = false;
        teleportPoint.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(PasswordPannel.GetComponent<PasswordPannel>().passwordIsCorrect){
            door.GetComponent<Animator>().SetBool("openDoor",true);
            teleportPoint.SetActive(true);
            teleportPoint.GetComponent<TeleportMarkerBase>().markerActive = true;
            door.GetComponent<AudioSource>().Play(0);
        }
    }
}
