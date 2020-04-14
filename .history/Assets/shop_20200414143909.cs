using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class shop : MonoBehaviour
{
    // Start is called before the first frame update
    public Button magnetBtn;
    public Toggle magnetTog;
    public Button gravityBtn;
    public Button slowBtn;
    public Button shieldBtn;
    public Button purchaseBtn;
    public Text coin;

    public bool isMagnet;
    public bool isGravity; 
    public bool isShield;
    public bool isSlow;

    int coinNum = 0;
    int magnetCost = 3;
    void Start()
    {
        coinNum = PlayerPrefs.GetInt("coin");
        coin.text = "x" + coinNum;
        if(PlayerPrefs.GetInt("magnet")==1){
            magnetBtn.interactable = false;
        }
        if(PlayerPrefs.GetInt("gravity")==1){
            gravityBtn.interactable = false;
        }
        if(PlayerPrefs.GetInt("shield")==1){
            shieldBtn.interactable = false;
        }
        if(PlayerPrefs.GetInt("slow")==1){
            slowBtn.interactable = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void magnetHandler(){
        if(coinNum - magnetCost >= 0 && !isMagnet){
            isMagnet = !isMagnet;
            magnetTog.isOn = isMagnet;
            coinNum -= magnetCost;
            coin.text = "x" + coinNum;
            //move to confirm purchase
            PlayerPrefs.SetInt("magnet", 1);
            PlayerPrefs.SetInt("coin", coinNum);
        }else if(isMagnet){
            isMagnet = !isMagnet;
            magnetTog.isOn = isMagnet;
            coinNum += magnetCost;
            coin.text = "x" + coinNum;
            PlayerPrefs.SetInt("magnet", 0);
            PlayerPrefs.SetInt("coin", coinNum);
        }
        
    }

    public void confirmPurchase(){

    }
}
