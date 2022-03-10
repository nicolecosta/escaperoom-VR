using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasswordPannel : MonoBehaviour
{
    public List<int> passwordCorrect =  new List<int>{4,2,8,5,1};
    public List<int> currentPassword;
    public bool passwordIsCorrect;
    public GameObject circleLight;
    public Renderer thisRenderer;
    private float resetTimerFixed;
    private float timer;
    private bool activeTimer;

    void Start()
    {
        resetTimerFixed = 40f;
        timer = resetTimerFixed;
    }

    void Update()
    {
        if(activeTimer){
            timer -= Time.deltaTime;
        }

        if(timer <= 0){
            currentPassword.Clear();
            timer = resetTimerFixed;
            activeTimer = false;
        }

        if(PasswordCheckMatch()){
            thisRenderer.material.color = Color.green;
            passwordIsCorrect = true;
        }
    }

    public void PanelButton1(){
        activeTimer = true;
        if(currentPassword.Count < passwordCorrect.Count){
            currentPassword.Add(1);
            GetComponent<AudioSource>().Play(0);
        }
        for(int i = 0; i < currentPassword.Count; i++){
            if(currentPassword[i] != passwordCorrect[i]){
                currentPassword.Clear();
            }
        }
    }

    public void PanelButton2(){
        activeTimer = true;
        if(currentPassword.Count < passwordCorrect.Count){
            currentPassword.Add(2);
            GetComponent<AudioSource>().Play(0);
        }
        for(int i = 0; i < currentPassword.Count; i++){
            if(currentPassword[i] != passwordCorrect[i]){
                currentPassword.Clear();
            }
        }
    }

    public void PanelButton3(){
        activeTimer = true;
        if(currentPassword.Count < passwordCorrect.Count){
            currentPassword.Add(3);
            GetComponent<AudioSource>().Play(0);
        }
        for(int i = 0; i < currentPassword.Count; i++){
            if(currentPassword[i] != passwordCorrect[i]){
                currentPassword.Clear();
            }
        }
    }

    public void PanelButton4(){
        activeTimer = true;
        if(currentPassword.Count < passwordCorrect.Count){
            currentPassword.Add(4);
            GetComponent<AudioSource>().Play(0);
        }
        for(int i = 0; i < currentPassword.Count; i++){
            if(currentPassword[i] != passwordCorrect[i]){
                currentPassword.Clear();
            }
        }
    }

    public void PanelButton5(){
        activeTimer = true;
        if(currentPassword.Count < passwordCorrect.Count){
            currentPassword.Add(5);
            GetComponent<AudioSource>().Play(0);
        }
        for(int i = 0; i < currentPassword.Count; i++){
            if(currentPassword[i] != passwordCorrect[i]){
                currentPassword.Clear();
            }
        }
    }

    public void PanelButton6(){
        activeTimer = true;
        if(currentPassword.Count < passwordCorrect.Count){
            currentPassword.Add(6);
            GetComponent<AudioSource>().Play(0);
        }
        for(int i = 0; i < currentPassword.Count; i++){
            if(currentPassword[i] != passwordCorrect[i]){
                currentPassword.Clear();
            }
        }
    }

    public void PanelButton7(){
        activeTimer = true;
        if(currentPassword.Count < passwordCorrect.Count){
            currentPassword.Add(7);
            GetComponent<AudioSource>().Play(0);
        }
        for(int i = 0; i < currentPassword.Count; i++){
            if(currentPassword[i] != passwordCorrect[i]){
                currentPassword.Clear();
            }
        }
    }

    public void PanelButton8(){
        activeTimer = true;
        if(currentPassword.Count < passwordCorrect.Count){
            currentPassword.Add(8);
            GetComponent<AudioSource>().Play(0);
        }
        for(int i = 0; i < currentPassword.Count; i++){
            if(currentPassword[i] != passwordCorrect[i]){
                currentPassword.Clear();
            }
        }
    }

    public void PanelButton9(){
        activeTimer = true;
        if(currentPassword.Count < passwordCorrect.Count){
            currentPassword.Add(9);
            GetComponent<AudioSource>().Play(0);
        }
        for(int i = 0; i < currentPassword.Count; i++){
            if(currentPassword[i] != passwordCorrect[i]){
                currentPassword.Clear();
            }
        }
    }

    public bool PasswordCheckMatch() {
        if (currentPassword.Count != passwordCorrect.Count){
            return false;
        }
            
        for (int i = 0; i < currentPassword.Count; i++) {
            if (currentPassword[i] != passwordCorrect[i]){
                return false;
            }   
        }
        return true;
    }
}
