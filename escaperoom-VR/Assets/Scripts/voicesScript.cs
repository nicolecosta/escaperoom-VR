using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class voicesScript : MonoBehaviour
{
    public List<string> thoughtsList =  new List<string>{
        "you're stupid",
        "you annoy me",
        "I HATE YOU",
        "WHY DON'T YOU DIE",
        "I'm thinking about toasting myself",
        "you need to grow up",
        "I can't stand you",
        "I wish you could just go away",
        "nobody cares about you",
        "you're a nobody"
        };
    public GameObject target;

    private float changeTime;

    private float StartChangeTime;

    public List<GameObject> voicesList;

    public GameObject textPrefab;

    private Vector3 textPosition;

    private AudioSource audioS;

    private int count;

    private int maxCount;

    void Start()
    {
        count = 0;
        StartChangeTime = 6f;
        changeTime = StartChangeTime;
        voicesList.Add(transform.GetChild(0).gameObject);
        textPosition = voicesList[0].transform.position;
        audioS = GetComponent<AudioSource>();
        maxCount = 0;
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
            count += 1;
        }

        if(count >= 40 && maxCount <= 10){
            count = 0;
            maxCount += 1;
            IntantiateNewVoice();
        }

        if(maxCount >= 10){
            count = 0;
        }
    }

    public void newThought(){
        foreach(GameObject voice in voicesList)
        {
            voice.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<TMP_Text>().text = thoughtsList [Random.Range(0, thoughtsList.Count)];
        }
    }

    public void IntantiateNewVoice(){
        GameObject newVoice = Instantiate(textPrefab,textPosition,Quaternion.identity);
        newVoice.transform.SetParent(this.transform);
    }


}
