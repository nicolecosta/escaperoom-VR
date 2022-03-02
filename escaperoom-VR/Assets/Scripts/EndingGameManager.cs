using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingGameManager : MonoBehaviour
{
    private float startEndingTime;
    private float endingTime;
    void Start()
    {
        startEndingTime = 30f;
        endingTime = startEndingTime;
    }

    // Update is called once per frame
    void Update()
    {
        endingTime -= Time.deltaTime;

        if(endingTime <= 0f){
            loadCredits();
        }
    }

    public void loadCredits(){
        //turn of lights
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
