using UnityEngine;

public class sourceVisuals : MonoBehaviour
{
    [SerializeField]
    Material mat;
    [SerializeField]
    Color EmissionColor;
    [SerializeField]
    float EmissionStrength = 1, scaleMultiplyer = 1;

    Vector3 scale;
    float scaleFac;

    void Start() {
        scale = transform.localScale;
    }


    void Update()
    {
        mat.SetColor("_EmissionColor", EmissionColor * visualizerPlane.amplitude * EmissionStrength);
        mat.SetColor("_Color", new Color(0,0,0, visualizerPlane.amplitude * EmissionStrength));
        Debug.Log(visualizerPlane.amplitude);
        scaleFac = 1 + visualizerPlane.amplitude * scaleMultiplyer;
        transform.localScale = scale * scaleFac;
    }
}
