using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolbarController : MonoBehaviour
{
    public GameObject Toolbar;

    public void OpenToolbar()
    {
        if (Toolbar == null)
        {
            Toolbar.SetActive(true);
            OpenToolbar();
        }
        else if (Toolbar != null)
        {
            Animator animator = Toolbar.GetComponent<Animator>();
            if (animator != null)
            {
                animator.SetBool("open", true);
            }
        }
    }

    public void CloseToolbar()
    {
        if (Toolbar == null)
        {
            Debug.Log("There was an error, closing the toolbar. It hasn't been initialized yet!");
        }
        else if (Toolbar != null)
        {
            Animator animator = Toolbar.GetComponent<Animator>();
            if (animator != null)
            {
                animator.SetBool("open", false);
            }
        }
    }
}
