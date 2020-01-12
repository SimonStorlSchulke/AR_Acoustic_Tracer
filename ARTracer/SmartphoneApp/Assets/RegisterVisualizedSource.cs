using UnityEngine;

[RequireComponent (typeof (AudioSource))]
public class RegisterVisualizedSource : MonoBehaviour
{
    void invoke()
    {
        Debug.Log("Registered AudioSource");
        visualizerPlane.speakerPos = this.transform;
        visualizerPlane.Audio = this.GetComponent<AudioSource>();
    }
}
