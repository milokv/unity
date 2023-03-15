using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buyAutoClicker : MonoBehaviour
{
    public int autoClickers;
    private logicScript logic;

    // Start is called before the first frame update
    void Start()
    {
       logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        Mathf.Pow(1.1f, autoClickers);
    }

    public void buyClickerButton()
    {
        if (logic.currentMoney >= (15 * Mathf.Pow(1.1f, autoClickers)))
        {
            logic.currentMoney = logic.currentMoney - (15 * Mathf.Pow(1.1f, autoClickers));
            autoClickers = autoClickers + 1;
            Debug.Log("Bought Autoclicker");
        }
        else Debug.Log("Tried to buy autoclicker, not enough money.");
            
    }


}
