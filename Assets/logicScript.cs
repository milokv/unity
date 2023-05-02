using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class logicScript : MonoBehaviour
{
    public float currentMoney;
    public Text moneyText;
    public float clickValue;
    
    // add option in unity to increase stor manually, for testing purpouses.
    [ContextMenu("Increase Score")]
    public void addScore()
    {
        // adding clickvalue to money, then pushing it to the text gameobject which shows money.
        // "#0.0#" is formatting to make atleast 1 decimal and max 2 decimals show
        currentMoney += clickValue;
        moneyText.text = currentMoney.ToString("#0.0#");

    }
    public void quitGame()
    {
        Application.Quit();
        Debug.Log("Exiting Application");
        //quit button + logging everytime its pressed
    }
}