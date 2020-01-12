using UnityEngine;

public class visualizerPlane : MonoBehaviour
{
    public static Transform speakerPos;
    public static AudioSource Audio;
    public Gradient heatmap;
    MovingSoundSorce source;

    [SerializeField]
    float ampScale = 20, opacityFade = .75f, planeScale = 0.1f;

    [SerializeField]
    int textureRes = 32, samples = 64;

    Material material;
    Texture2D tex;
    static float[] spectrum;


    void Start() {
        spectrum = new float[samples];
        tex = new Texture2D(textureRes, textureRes);
        material = GetComponent<Renderer>().material;
        material.SetTexture("_MainTex", tex);
    }

    void Update() {
        GetSpectrumData();
        float amplitude = 0;
        foreach (float v in spectrum) amplitude += v;
        amplitude = amplitude / spectrum.Length * ampScale;
        calcTexture(amplitude, speakerPos.position);
    }

    void GetSpectrumData() {
        if (Audio != null && Audio.isPlaying) {
            Audio.GetSpectrumData(samples, 0, FFTWindow.Blackman);
        }
    }

    Vector3 texPos;
    float distToSpeaker;
    Color col;
    void calcTexture(float amplitude, Vector3 speakerPos) {

        speakerPos *= planeScale;

        //Texture Generation Loop
        for (int x = 0; x < textureRes; x++) {
            for (int z = 0; z < textureRes; z++) {

                texPos.y = this.transform.position.y;
                texPos.x = (x - (tex.width / 2)) * (2f / textureRes);
                texPos.z = (z - (tex.height / 2)) * (2f / textureRes);

                distToSpeaker = 1 - Vector3.Distance(speakerPos, texPos);

                col = heatmap.Evaluate(distToSpeaker * amplitude);

                //Fade out texture for lower amplitude
                col.a = Mathf.Pow(distToSpeaker * amplitude, opacityFade);

                tex.SetPixel(x, z, col);
            }
        }
        tex.Apply(false);
    }
}
