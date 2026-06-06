using UnityEngine;
using UnityEngine.SceneManagement;
// memanggil sistem scene

public class NextLevel : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    // saat player menyentuh finish
    {
        if (other.CompareTag("Player"))
        // jika yang menyentuh adalah player
        {
            int currentLevel =
                SceneManager.GetActiveScene().buildIndex;
            // mengambil index level sekarang

            int unlockedLevel =
                PlayerPrefs.GetInt("UnlockedLevel", 1);
            // mengambil level yang terbuka

            if (currentLevel >= unlockedLevel)
            // jika level sekarang lebih tinggi
            {
                PlayerPrefs.SetInt(
                    "UnlockedLevel",
                    currentLevel + 1
                );
                // membuka level berikutnya
            }

            SceneManager.LoadScene(currentLevel + 1);
            // pindah ke level berikutnya
        }
    }
}