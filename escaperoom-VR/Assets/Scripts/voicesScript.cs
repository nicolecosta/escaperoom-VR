using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class voicesScript : MonoBehaviour
{
    public GameObject voices;
    public List<string> thoughtsList =  new List<string>{
        "you're stupid",
        "you annoy me",
        "I HATE YOU",
        "WHY DON'T YOU DIE",
        "I'm thinking about toasting myself",
        "you need to grow up",
        "I can't stand you"
        };
    public GameObject target;

    private float changeTime;

    private float StartChangeTime;

    public List<GameObject> voicesList;

    public GameObject textPrefab;

    public GameObject GM;

    private Vector3 textPosition;

    public List<AudioClip> audioList;

    private AudioSource audioS;

    void Start()
    {
        StartChangeTime = 4f;
        changeTime = StartChangeTime;
        voicesList.Add(transform.GetChild(0).gameObject);
        GM = GameObject.Find("GameManager");
        textPosition = voicesList[0].transform.position;
        audioS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        foreach(GameObject voice in voicesList)
        {
            voice.transform.RotateAround(target.transform.position, new Vector3(1,1,1) , 80 * Time.deltaTime);
        }
        

        changeTime -= Time.deltaTime;

        if(changeTime <= 0){
            changeTime = StartChangeTime;
            newThought();

        }
    }

    public void newThought(){
        foreach(GameObject voice in voicesList)
        {
            voice.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<TMP_Text>().text = thoughtsList [Random.Range(0, thoughtsList.Count)];
            audioS.clip = audioList[Random.Range(0, audioList.Count)];
            audioS.Play();
        }
    }

    public void IntantiateNewVoice(){
        Instantiate(textPrefab,textPosition,Quaternion.identity);
        audioS.clip = audioList[Random.Range(0, audioList.Count)];
        audioS.Play();
    }


}
