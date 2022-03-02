using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public GameObject text;
    public GameObject menu;
    void Start()
    {
        text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayButton(){
        text.SetActive(true);
        menu.SetActive(false);
        //play audio
        LoadNextSceneAfter(6f);
        
    }

    public void QuitButton(){
        Application.Quit();
    }

    

    IEnumerator LoadNextSceneAfter(float seconds) {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
