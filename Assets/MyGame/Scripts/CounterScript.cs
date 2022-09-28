using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CounterScript : MonoBehaviour
{
    public TextMeshProUGUI text;

    public int number;
    
    public void Plus()
    {
        number++;
        text.text = number.ToString();
    }
    public void Minus()
    {
        number--;
        text.text = number.ToString();
    }
    public void ResetCounter()
    {
        number=0;
        text.text = number.ToString();
    }

    public void TimesTwo()
    {
        number *=2;
        text.text = number.ToString();
    }
    public void Half()
    {
        number /=2;
        text.text = number.ToString();
    }


}