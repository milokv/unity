using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class logicScript : MonoBehaviour
{
    public float currentMoney;
    public Text moneyText;
    public float clickValue;
    private float clickCount = 0;
    private float lastClickTime = 0f;
    private float cps = 0f;
    public Text clickPerSecond;

    // add option in unity to increase score manually, for testing purpouses.
    [ContextMenu("Increase Score")]
    public void addScore()
    {
        // adding clickvalue to money, then pushing it to the text gameobject which shows money.
        // "#0.0#" is formatting to make atleast 1 decimal and max 2 decimals show
        currentMoney += clickValue;
        moneyText.text = currentMoney.ToString("#0.0#");

        // calculate CPS
        if (Time.time - lastClickTime > 0.5f)
        {
            cps = clickCount / (Time.time - lastClickTime);
            lastClickTime = Time.time;
            clickCount = 1;
        }
        else
        {
            clickCount++;
        }

        clickPerSecond.text = ("CPS: " + cps.ToString("#0.0#"));
    }

    // Update is called once per frame
    void Update()
    {
        // set cps as 0 if player hasn't clicked for 2 seconds
        if (Time.time - lastClickTime > 2f)
        {
            cps = 0;
            clickPerSecond.text = ("CPS: " + cps.ToString("#0.0#"));
        }
    }

    public void quitGame()
    {
        Application.Quit();
        Debug.Log("Exiting Application");
        //quit button + logging everytime its pressed
    }
}