using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buyAutoClicker : MonoBehaviour
{
    public int autoClickers;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        autoClickers = autoClickers + 1;
    }


}
