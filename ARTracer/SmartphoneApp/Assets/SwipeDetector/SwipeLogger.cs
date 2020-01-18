using UnityEngine;

public class SwipeLogger : MonoBehaviour
{
    public GameObject one, two, drei;
    public visualizerPlane plane;
    public Gradient newG;
    public Gradient planeG;
    private void Awake()
    {
        SwipeDetector.OnSwipe += SwipeDetector_OnSwipe;
        plane = GameObject.Find("visualizerPlane").GetComponent<visualizerPlane>();
        planeG = GameObject.Find("visualizerPlane").GetComponent<visualizerPlane>().heatmap;
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
                        plane.pixelated = true;
                        plane.heatmap = planeG;
                    }

                    else if (two.activeSelf == true)
                    {
                        one.SetActive(false);
                        two.SetActive(false);
                        drei.SetActive(true);

                        plane.pixelated = false;
                        plane.heatmap = newG;
                    }

                    else if (drei.activeSelf == true)
                    {
                        one.SetActive(true);
                        two.SetActive(false);
                        drei.SetActive(false);
                        plane.pixelated = false;
                        plane.heatmap = planeG;
                    }
                }
            }
        }
        
    }

   
}