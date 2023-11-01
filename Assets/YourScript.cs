using UnityEngine;

public class YourScript : MonoBehaviour
{
    public AudioManagerScript audioManager; // Reference to the AudioManager script

    private void Start()
    {
        // Call the PlaySongWithDelay function with a 3-second delay
        Invoke("PlaySongWithDelay", 4f);
    }

    private void PlaySongWithDelay()
    {
        audioManager.PlaySongWithDelay();
    }
}
