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
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void magnetHandler(){
        magnetTog.isOn = !magnetTog.isOn;
    }
}
