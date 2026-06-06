using UnityEngine;
// Menggunakan fitur dasar Unity

using UnityEngine.UI;
// Menggunakan fitur UI seperti Slider dan Toggle

public class AudioSettings : MonoBehaviour
// Membuat class bernama AudioSettings
// MonoBehaviour = script bisa dipasang ke GameObject Unity
{
    public AudioSource MenuMusic;
    // Mengambil Audio Source dari object MenuMusic

    public Slider volumeslider;
    // Mengambil Slider untuk mengatur volume

    public Toggle audiotoggle;
    // Mengambil Toggle untuk ON/OFF audio

    void Start()
    // Start() dijalankan otomatis saat game dimulai
    {
        volumeslider.value = MenuMusic.volume;
        // Membuat nilai slider sama dengan volume musik saat awal game
    }

    public void ChangeVolume()
    // Function untuk mengubah volume
    {
        MenuMusic.volume = volumeslider.value;
        // Volume musik mengikuti posisi slider
    }

    public void ToggleAudio()
    // Function untuk ON/OFF audio
    {
        MenuMusic.mute = !audiotoggle.isOn;
        // Jika toggle OFF → musik mute
        // Jika toggle ON → musik menyala
    }
}