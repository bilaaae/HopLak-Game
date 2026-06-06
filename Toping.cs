using UnityEngine;

public class Topping : MonoBehaviour
{
    public int nilai = 1;

    public AudioClip makanSound;

    AudioSource audioSource;

    void Start()
    {
        audioSource = FindObjectOfType<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreManager.instance.TambahScore(nilai);

            audioSource.PlayOneShot(makanSound);

            Destroy(gameObject);
        }
    }
}