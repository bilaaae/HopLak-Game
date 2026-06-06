using UnityEngine; // Memakai fitur Unity

public class CabeAtasBawah : MonoBehaviour
{
    // Kecepatan gerakan cabe
    public float speed = 2f;

    // Jarak gerakan cabe
    public float distance = 2f;

    // Menyimpan posisi awal cabe
    private Vector3 startPos;

    // Berjalan sekali saat game dimulai
    void Start()
    {
        // Menyimpan posisi awal object
        startPos = transform.position;
    }

    // Berjalan terus setiap frame
    void Update()
    {
        // Menggerakkan cabe atas bawah
        transform.position = startPos + new Vector3(

            // Tidak bergerak kanan kiri
            0,

            // Gerakan atas bawah bolak balik
            Mathf.Sin(Time.time * speed) * distance,

            // Tidak bergerak depan belakang
            0
        );
    }
}