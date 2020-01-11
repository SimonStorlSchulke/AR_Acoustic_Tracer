using UnityEngine;

public class SwipeLogger : MonoBehaviour
{
    public GameObject one, two, drei;
    private void Awake()
    {
        SwipeDetector.OnSwipe += SwipeDetector_OnSwipe;
    }

    public void SwipeDetector_OnSwipe(SwipeData data)
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100f))
        {
            if (hit.collider.CompareTag("Swipe"))
            {
                if (data.Direction == SwipeDirection.Left)
                {
                    if (one.activeSelf == true)
                    {
                        one.SetActive(false);
                        two.SetActive(true);
                        drei.SetActive(false);
                    }

                    else if (two.activeSelf == true)
                    {
                        one.SetActive(false);
                        two.SetActive(false);
                        drei.SetActive(true);
                    }

                    else if (drei.activeSelf == true)
                    {
                        one.SetActive(true);
                        two.SetActive(false);
                        drei.SetActive(false);
                    }
                }
            }
        }
        
    }
}