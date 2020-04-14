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
    public Button timeBtn;
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
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void magnetHandler(){
        if(coinNum - magnetCost > 0 && !isMagnet){
            isMagnet = !isMagnet;
            magnetTog.isOn = isMagnet;
            coinNum -= magnetCost;
            coin.text = "x" + coinNum;
        }else{
            isMagnet = !isMagnet;
            magnetTog.isOn = isMagnet;
            coinNum += magnetCost;
            coin.text = "x" + coinNum;
        }
        
    }

    public void confirmPurchase(){

    }
}
