using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;


public class UnlockLevel : MonoBehaviour
{
    private Button[] lvlButtons;
    private int totalHearts;
    private int heartCount = 0;
    private Scene scene;
    [SerializeField]
    private int[] heartsHunted;
    [SerializeField]
    private int[] heartsNeeded;
    private readonly int NUM_OF_LEVELS = 6;


    // Start is called before the first frame update
    void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
        totalHearts = 0;
        foreach (int x in heartsHunted)
        {
            totalHearts += x;
        }
    }

    private void OnSceneLoaded(Scene aScene, LoadSceneMode aMode)
    {
        foreach (int x in heartsHunted)
        {
            totalHearts += x;
        }
        scene = aScene;
        if (aScene.name == "OptionMenu")// unlock and lock levels
        {
            lvlButtons = FindObjectsOfType<Button>();
            foreach (Button btn in lvlButtons) //iterate over buttons
            {
                string name = btn.name.Substring(5);
                int lvl = Int32.Parse(name);
                if (totalHearts < heartsNeeded[lvl - 1])
                {
                    // change the button to inactive in here
                    btn.GetComponent<Button>().interactable = false;
                }

            }
        }
        else // playable level
        {
            try
            {
                Int32.Parse(aScene.name);
                setUpLevel();
            }
            catch (Exception ee)
            {

            }
        }
    }
    private void setUpLevel()
    {
        heartCount = 0;
    }
    // Update is called once per frame
    void Update()
    {

    }
    public void addHeartCount()
    {
        heartCount++;
    }
    public void endlevel()
    {
        Debug.Log(heartCount);
        if (heartCount > heartsHunted[Int32.Parse(scene.name) - 1])
        {
            heartsHunted[Int32.Parse(scene.name) - 1] = heartCount;
        }
        int rewardCoin  = heartCount;//this is used to count the reward coin
        int coin = PlayerPrefs.GetInt("coin") + rewardCoin;
        PlayerPrefs.SetInt("coin", coin);
    }
    public void newGame()
    {
        heartsHunted = new int[NUM_OF_LEVELS];
    }

}

