
    using UnityEngine;
public class AutoRotation : MonoBehaviour
{
    [Tooltip("Angular velocity in degrees per seconds")]
    public float degPerSec = 60.0f;

    [Tooltip("Rotation axis")]
    public Vector3 rotAxis = Vector3.up;

    bool up = true;

    // Use this for initialization
    private void Start()
    {
        rotAxis.Normalize();
    }



    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(rotAxis, degPerSec * Time.deltaTime);
        MoveVertical();
    }
    void MoveVertical()
    {
        var temp = transform.position;
        print(up);
        if (up == true)
        {
            temp.y += 0.0005f;
            transform.position = temp;
            if (transform.position.y >= 0.08f)
            {
                up = false;
            }
        }
        if (up == false)
        {
            temp.y -= 0.001f;
            transform.position = temp;
            if (transform.position.y <= 0.02f)
            {
                up = true;
            }
        }
    }
}
