using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject objectToColor;
    bool favourite = false;
    public void ColourChange()
    {
        favourite = !favourite;
        if(favourite)
        {
            objectToColor.GetComponent<Image>().color = Color.yellow;
        }
        else
        {
            objectToColor.GetComponent<Image>().color = Color.black;
        }
    }
}
