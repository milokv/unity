using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buyAutoClicker : MonoBehaviour
{
    public int autoClickers;
    public int clickUpgrades;
    private logicScript logic;

    // text variable(?) where the text gameobject is dragged into so the text gets pushed there
    public Text clickerCost;
    public Text clickUpgradeCost;

    // List of prices for click upgrade
    List<int> clickUpgradeChart = new List<int>() {
   200,
   400,
   800,
};

    // Start is called before the first frame update
    void Start()
    {
        // importing the logic game object and script to this script
       logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buyClickUpgrade()
    {
        if (logic.currentMoney >= (clickUpgradeChart[clickUpgrades]))
        {
            logic.currentMoney = logic.currentMoney - (clickUpgradeChart[clickUpgrades]);
            clickUpgrades = clickUpgrades + 1;
            // taking money and adding another click upgrade
            clickUpgradeCost.text = ("Cost: " + (clickUpgradeChart[clickUpgrades]).ToString("#0.0#"));
            // pushing the new cost for the upgrade to the upgrade price text, according to the chart
            logic.clickValue = (clickUpgrades + 1);
            // updating the money gained per click.
            Debug.Log("Bought Click Upgrade");
        }
        else Debug.Log("Tried to buy Click Upgrade, Could not afford.");
        // logging that buy failed bc low money
    }

    public void buyClickerButton()
    {
        // check if player has the same or more amount of money that autoclicker costs
        if (logic.currentMoney >= (15 * Mathf.Pow(1.1f, autoClickers)))
        {
            // remove the price of the autoclicker (15 times 1.1 to the power of the number of autoclickers) from balance
            logic.currentMoney = logic.currentMoney - (15 * Mathf.Pow(1.1f, autoClickers));
            // Change internal value of autoclickers bought by +1
            autoClickers = autoClickers + 1;
            // Push the new cost to pricetag in game
            clickerCost.text = ("Cost: " + (15 * Mathf.Pow(1.1f, autoClickers)).ToString("#0.0#"));
            Debug.Log("Bought Autoclicker");
        }
        else Debug.Log("Tried to buy autoclicker, not enough money.");
            
    }


}
