using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoClickerLogic : MonoBehaviour
{

    private buyAutoClicker autoClick;
    private logicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        // importing buyAutoClicker and logicScript to this script from the logic and autoclicker game objects.
        autoClick = GameObject.FindGameObjectWithTag("autoClicker").GetComponent<buyAutoClicker>();
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        // adding 0.1 money per autoclicker bought per second
        logic.currentMoney = logic.currentMoney + 0.1f * (Time.deltaTime * autoClick.autoClickers);
        // adding 1 money per autoclicker 2 per second
        logic.currentMoney = logic.currentMoney + 1f * (Time.deltaTime * autoClick.autoClicker2);
        logic.moneyText.text = logic.currentMoney.ToString("#0.0#");
    }
}
