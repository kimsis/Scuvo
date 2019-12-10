using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchHandler : MonoBehaviour
{

    public GameObject toolBar;
    Vector3 touchStart;

    public ToolbarController controller;

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount == 1)
        {
            var finger = Input.GetTouch(0);

            if (finger.phase == TouchPhase.Began)
            {
                touchStart = finger.position;
                Debug.Log("IF Number 1");
            }
            else if (finger.phase == TouchPhase.Ended)
            {
                var totalDistance = finger.position.x - touchStart.x;
                Debug.Log("Total distance: " + totalDistance);

                if (finger.tapCount == 1 && toolBar.activeSelf && finger.position.x > 100 && totalDistance > -20 && totalDistance < 20)
                {
                    controller.CloseToolbar();
                    Debug.Log("IF Number 4 " + finger.position.x);
                    return;
                }

                if (totalDistance >= 100 && toolBar.activeSelf)
                {
                    controller.OpenToolbar();
                    Debug.Log("IF Number 5");
                }

                else if (totalDistance < -20 && toolBar.activeSelf)
                {
                    controller.CloseToolbar();
                    Debug.Log("IF Number 6");
                }
            }

        }
    }

    
}
