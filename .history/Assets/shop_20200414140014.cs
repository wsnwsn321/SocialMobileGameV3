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

    int coinNum = 0;
    int magnetCost = 5;
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
        if(!magnetTog){
            magnetTog.isOn = !magnetTog.isOn;
        }
        
    }

    public void confirmPurchase(){

    }
}
