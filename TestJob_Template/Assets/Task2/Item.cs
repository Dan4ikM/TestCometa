using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    private Text itemText;
    private int countClicks = 0;
    
    private void Start()
    {
        itemText = GetComponentInChildren<Text>();
        UiUpdate();
    }

    public void IncreaseCounter()
    {
        countClicks++;
        UiUpdate();
    }

    private void UiUpdate()
    {
        itemText.text = "- Item - {" +countClicks + "} clicks";
    }
}
