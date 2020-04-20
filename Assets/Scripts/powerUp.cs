using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class powerUp : MonoBehaviour
{
    public Button magnetBtn;
    public Button gravityBtn;
    public Button slowBtn;
    public Button shieldBtn;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("magnet") == 1){
            magnetBtn.interactable = true;
            Debug.Log(PlayerPrefs.GetInt("magnet"));
        }else{
            magnetBtn.interactable = false;
        }
        if(PlayerPrefs.GetInt("gravity") == 1){
            gravityBtn.interactable = true;
        }
        else{
            gravityBtn.interactable = false;
        }
        if(PlayerPrefs.GetInt("slow") == 1){
            slowBtn.interactable = true;
        }else{
            slowBtn.interactable = false;
        }
        if(PlayerPrefs.GetInt("shield") == 1){
            shieldBtn.interactable = true;
        }else{
            shieldBtn.interactable = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void magnetChange(){
        PlayerPrefs.SetInt("magnet", 0);
        //Debug.Log(PlayerPrefs.GetInt("magnet"));
    }
    public void gravityChange(){
        PlayerPrefs.SetInt("gravity", 0);
    }
    public void slowChange(){
        PlayerPrefs.SetInt("slow", 0);
    }
    public void shieldChange(){
        PlayerPrefs.SetInt("shield", 0);
    }
}
