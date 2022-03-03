using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public GameObject menu;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayButton(){
        menu.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }

    public void QuitButton(){
        Application.Quit();
    }

    

    IEnumerator LoadNextSceneAfter(float seconds) {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
