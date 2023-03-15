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
        autoClick = GameObject.FindGameObjectWithTag("autoClicker").GetComponent<buyAutoClicker>();
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicScript>();
        // importing buyAutoClicker and logicScript to this script
    }

    // Update is called once per frame
    void Update()
    {
        logic.currentMoney = logic.currentMoney + 0.1f * (Time.deltaTime * autoClick.autoClickers);
        logic.moneyText.text = logic.currentMoney.ToString("#0.0#");

    }
}
