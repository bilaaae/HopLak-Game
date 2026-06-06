using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public Button[] levelButtons;

    void Start()
    {
        // ambil level yang sudah terbuka
        int unlockedLevel = PlayerPrefs.GetInt("UnlockedLevel", 1);

        for (int i = 0; i < levelButtons.Length; i++)
        {
            // kalau level sudah kebuka
            if (i < unlockedLevel)
            {
                levelButtons[i].interactable = true;  // bisa diklik
            }
            else
            {
                levelButtons[i].interactable = false; // terkunci (abu-abu)
            }
        }
    }

    // pindah ke level
    public void OpenLevel(int index)
    {
        // +1 karena:
        // 0 MainMenu
        // 1 Level1
        // 2 Level2
        SceneManager.LoadScene(index + 1);
    }

    // balik ke menu
    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}