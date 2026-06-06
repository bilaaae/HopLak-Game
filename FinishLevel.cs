using UnityEngine;
// memakai fitur Unity

using UnityEngine.SceneManagement;
// untuk pindah scene / level

public class FinishLevel : MonoBehaviour
// script finish level
{
    void OnTriggerEnter2D(Collider2D other)
    // saat player menyentuh finish
    {
        // Mengecek apakah yang menyentuh Player
        if (other.CompareTag("Player"))
        {
            // Mengambil index scene sekarang
            int currentScene = SceneManager.GetActiveScene().buildIndex;

            // Mengecek apakah masih ada level berikutnya
            if (currentScene < SceneManager.sceneCountInBuildSettings - 1)
            {
                // Pindah ke level berikutnya
                SceneManager.LoadScene(currentScene + 1);
            }
            else
            {
                // Jika sudah level terakhir
                // kembali ke MainMenu
                SceneManager.LoadScene("MainMenu");
            }
        }
    }
}