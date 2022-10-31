using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeButtonColor : MonoBehaviour
{
    [SerializeField] private Image changeColorImage;

    public void ColorChangeClick()
    {
        changeColorImage.color = Random.ColorHSV();
    }
}
