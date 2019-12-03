using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    private Text text;
    private int countClicks = 0;

    void Start()
    {
        text = GetComponentInChildren<Text>();
        UiUpdate();
    }

    public void IncreaseCounter()
    {
        if (GetComponent<MovementController>().SetIsMove())
            return;
        countClicks++;
        UiUpdate();
    }

    private void UiUpdate()
    {
        text.text = "- Item - {" + countClicks + "} clicks";
    }
}
