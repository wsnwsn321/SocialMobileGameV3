using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class shop : MonoBehaviour
{
    // Start is called before the first frame update
    public Toggle magnetTog;
    public Toggle gravityTog;
    public Toggle shieldTog;
    public Toggle slowTog;
    public Button magnetBtn;
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
    int magnetCost = 5;
    int gravityCost = 3;
    int shieldCost = 2;
    int slowCost = 1;
    void Start()
    {
        coinNum = PlayerPrefs.GetInt("coin");
        coinNum = 5;
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
        }else if(isMagnet){
            isMagnet = !isMagnet;
            magnetTog.isOn = isMagnet;
            coinNum += magnetCost;
            coin.text = "x" + coinNum;
        }
        
    }

    public void gravityHandler(){
        if(coinNum - gravityCost >= 0 && !isGravity){
            isGravity = !isGravity;
            gravityTog.isOn = isGravity;
            coinNum -= gravityCost;
            coin.text = "x" + coinNum;
        }else if(isMagnet){
            isGravity = !isGravity;
            gravityTog.isOn = isGravity;
            coinNum += gravityCost;
            coin.text = "x" + coinNum;
        }
        
    }

    public void shieldHandler(){
        if(coinNum - shieldCost >= 0 && !isShield){
            isShield = !isShield;
            shieldTog.isOn = isShield;
            coinNum -= shieldCost;
            coin.text = "x" + coinNum;
        }else if(isMagnet){
            isShield = !isShield;
            shieldTog.isOn = isShield;
            coinNum += shieldCost;
            coin.text = "x" + coinNum;
        }
        
    }

    public void slowHandler(){
        if(coinNum - slowCost >= 0 && !isSlow){
            isSlow = !isSlow;
            slowTog.isOn = isSlow;
            coinNum -= shieldCost;
            coin.text = "x" + coinNum;
        }else if(isMagnet){
            isShield = !isShield;
            shieldTog.isOn = isShield;
            coinNum += shieldCost;
            coin.text = "x" + coinNum;
        }
        
    }

    public void confirmPurchase(){
            if(isMagnet){
                PlayerPrefs.SetInt("magnet", 1);
            }

            if(isGravity){
                PlayerPrefs.SetInt("gravity", 1);
            }
            if(isShield){
               PlayerPrefs.SetInt("shield", 1);
            }
            if(isSlow){
                PlayerPrefs.SetInt("slow", 1);
            }

            
            PlayerPrefs.SetInt("coin", coinNum);



    }
}
