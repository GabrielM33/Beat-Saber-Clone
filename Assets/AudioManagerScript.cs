using UnityEngine;

public class AudioManagerScript : MonoBehaviour
{
    public AudioSource audioSource; // Reference to your AudioSource component

    public void PlaySongWithDelay()
    {
        audioSource.Play();
    }
}
