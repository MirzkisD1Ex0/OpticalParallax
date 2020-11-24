using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class BGMController : MonoBehaviour
{
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.enabled = false;
    }

    private void Update()
    {
        if (UIStatus.isShadowComplete)
        {
            audioSource.enabled = true;
        }
    }
}