using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickCount : MonoBehaviour
{
    public Text clickCount;

    private int count;
    public void ClickCounter()
    {
        count++;
        clickCount.text = count.ToString();
    }    
}
