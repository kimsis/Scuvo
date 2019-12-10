using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTab : MonoBehaviour
{
    public GameObject panelToBeOpenned;
    public GameObject canvas;
    public ToolbarController controller;

    public void OpenTab()
    {
        for (int i = 0; i < 5; i++)
        {
            canvas.transform.GetChild(i).gameObject.SetActive(false);
        }
        panelToBeOpenned.SetActive(true);
        controller.CloseToolbar();
    }
}
