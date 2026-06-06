using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
// memanggil fitur Unity, UI, dan Scene

public class PlayerHealth : MonoBehaviour
// script untuk mengatur nyawa player
{
    public int nyawa = 5;
    // jumlah nyawa player

    public Image[] sayur;
    // array gambar nyawa sayur

    public AudioClip hurtSound;
    // suara saat terkena cabai

    AudioSource audioSource;
    // komponen audio source

    Animator anim;
    // animator player

    void Start()
    {
        anim = GetComponent<Animator>();
        // mengambil animator player

        audioSource = GetComponent<AudioSource>();
        // mengambil audio source player

        UpdateSayur();
        // menampilkan nyawa awal
    }

    void OnTriggerEnter2D(Collider2D other)
    // saat player menyentuh trigger
    {
        if (other.CompareTag("Cabai"))
        // jika terkena cabai
        {
            Debug.Log("Kena Cabai");

            nyawa--;
            // mengurangi nyawa

            anim.SetTrigger("Hurt");
            // memainkan animasi hurt

            audioSource.PlayOneShot(hurtSound);
            // memainkan suara hurt

            Destroy(other.gameObject);
            // menghapus cabai

            UpdateSayur();
            // update tampilan nyawa

            Debug.Log("Nyawa: " + nyawa);

            if (nyawa <= 0)
            // jika nyawa habis
            {
                SceneManager.LoadScene(
                    SceneManager.GetActiveScene().buildIndex
                );
                // restart level yang sama
            }
        }
    }

    void UpdateSayur()
    // mengatur tampilan nyawa sayur
    {
        for (int i = 0; i < sayur.Length; i++)
        {
            if (i < nyawa)
            {
                sayur[i].enabled = true;
                // gambar sayur tampil
            }
            else
            {
                sayur[i].enabled = false;
                // gambar sayur hilang
            }
        }
    }
}