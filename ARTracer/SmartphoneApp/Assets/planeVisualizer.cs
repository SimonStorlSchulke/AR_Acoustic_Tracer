using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeVisualizer : MonoBehaviour
{
    public static Transform speakerPos;
    public Gradient heatmap;
    public AudioSource Audio;
    MovingSoundSorce source;

    [SerializeField]
    float ampScale = 20, opacityFade = .75f, planeScale = 0.1f;

    [SerializeField]
    int textureRes = 32, samples = 64;

    Material material;
    Texture2D tex;
    static float[] spectrum;
    public static float amplitude = 0;


    void Start()
    {
        spectrum = new float[samples];
        tex = new Texture2D(textureRes, textureRes);
        material = GetComponent<Renderer>().material;
        material.SetTexture("_MainTex", tex);
    }

    void Update()
    {
        //calculate Amplitude based on spectrum data
        if (Audio && Audio.isPlaying) Audio.GetSpectrumData(samples, 0, FFTWindow.Blackman);
        foreach (float v in spectrum) amplitude += v;
        amplitude = amplitude / spectrum.Length * ampScale;

        generateTexture(amplitude);
    }



    Vector3 texPos;
    float distToSpeaker;
    Color col;
    void generateTexture(float amplitude)
    {

        Color amp0Color = heatmap.Evaluate(0); amp0Color.a = 0;

        //Texture Generation Loop
        for (int x = 0; x < textureRes; x++)
        {
            for (int z = 0; z < textureRes; z++)
            {

                //calculate current pixel position
                texPos.y = this.transform.position.y;
                texPos.x = (x - (tex.width / 2)) * (2f / textureRes);
                texPos.z = (z - (tex.height / 2)) * (2f / textureRes);

                if (speakerPos && Audio)
                {
                    //colorize texture based on distance to speaker and current amplitude
                    distToSpeaker = 1 - Vector3.Distance(speakerPos.position * planeScale, texPos);
                    col = heatmap.Evaluate(distToSpeaker * amplitude);
                    //Fade out texture for lower amplitude
                    col.a = Mathf.Pow(distToSpeaker * amplitude, opacityFade);
                }
                else col = amp0Color;

                tex.SetPixel(x, z, col);
            }
        }
        tex.Apply(false);
    }
}
