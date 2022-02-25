using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasswordPannel : MonoBehaviour
{
    public List<int> passwordCorrect =  new List<int>{1,2,3,4,5};
    public List<int> currentPassword;
    public bool passwordIsCorrect;
    public GameObject circleLight;
    public Renderer renderer;

    void Start()
    {
        
    }

    void Update()
    {
        if(PasswordCheckMatch()){
            renderer.material.color = Color.green;
            passwordIsCorrect = true;
        }
    }

    public void PanelButton1(){
        if(currentPassword.Count < passwordCorrect.Count){
            currentPassword.Add(1);
        }
        for(int i = 0; i < currentPassword.Count; i++){
            if(currentPassword[i] != passwordCorrect[i]){
                currentPassword.Clear();
            }
        }
    }

    public void PanelButton2(){
        if(currentPassword.Count < passwordCorrect.Count){
            currentPassword.Add(2);
        }
        for(int i = 0; i < currentPassword.Count; i++){
            if(currentPassword[i] != passwordCorrect[i]){
                currentPassword.Clear();
            }
        }
    }

    public void PanelButton3(){
        if(currentPassword.Count < passwordCorrect.Count){
            currentPassword.Add(3);
        }
        for(int i = 0; i < currentPassword.Count; i++){
            if(currentPassword[i] != passwordCorrect[i]){
                currentPassword.Clear();
            }
        }
    }

    public void PanelButton4(){
        if(currentPassword.Count < passwordCorrect.Count){
            currentPassword.Add(4);
        }
        for(int i = 0; i < currentPassword.Count; i++){
            if(currentPassword[i] != passwordCorrect[i]){
                currentPassword.Clear();
            }
        }
    }

    public void PanelButton5(){
        if(currentPassword.Count < passwordCorrect.Count){
            currentPassword.Add(5);
        }
        for(int i = 0; i < currentPassword.Count; i++){
            if(currentPassword[i] != passwordCorrect[i]){
                currentPassword.Clear();
            }
        }
    }

    public void PanelButton6(){
        if(currentPassword.Count < passwordCorrect.Count){
            currentPassword.Add(6);
        }
        for(int i = 0; i < currentPassword.Count; i++){
            if(currentPassword[i] != passwordCorrect[i]){
                currentPassword.Clear();
            }
        }
    }

    public void PanelButton7(){
        if(currentPassword.Count < passwordCorrect.Count){
            currentPassword.Add(7);
        }
        for(int i = 0; i < currentPassword.Count; i++){
            if(currentPassword[i] != passwordCorrect[i]){
                currentPassword.Clear();
            }
        }
    }

    public void PanelButton8(){
        if(currentPassword.Count < passwordCorrect.Count){
            currentPassword.Add(8);
        }
        for(int i = 0; i < currentPassword.Count; i++){
            if(currentPassword[i] != passwordCorrect[i]){
                currentPassword.Clear();
            }
        }
    }

    public void PanelButton9(){
        if(currentPassword.Count < passwordCorrect.Count){
            currentPassword.Add(9);
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
