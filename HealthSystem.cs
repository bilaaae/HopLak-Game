using UnityEngine;
// fitur dasar Unity

using UnityEngine.UI;
// untuk UI Image (life/sayur)

using UnityEngine.SceneManagement;
// untuk restart scene

public class HealthSystem : MonoBehaviour
// script pengatur nyawa player
{
    public static HealthSystem instance;
    // akses global (biar bisa dipanggil dari script lain)

    public int nyawa = 5;
    // jumlah nyawa awal

    public Image[] life;
    // array gambar nyawa (sayur UI)

    void Awake()
    {
        instance = this;
        // simpan script ini agar bisa diakses dari mana saja
    }

    void Start()
    {
        UpdateUI();
        // tampilkan nyawa awal saat game mulai
    }

    void UpdateUI()
    {
        for (int i = 0; i < life.Length; i++)
        {
            if (i < nyawa)
                life[i].enabled = true;
            // masih punya nyawa → tampilkan sayur
            else
                life[i].enabled = false;
            // tidak punya → sembunyikan
        }
    }

    public void KurangiNyawa()
    {
        nyawa--;
        // kurangi 1 nyawa

        UpdateUI();
        // update tampilan UI

        if (nyawa <= 0)
        {
            SceneManager.LoadScene("Level1");
            // kalau habis → restart
        }
    }
}