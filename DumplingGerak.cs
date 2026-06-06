using UnityEngine; // Memakai fitur Unity

public class DumplingGerak : MonoBehaviour
{
    // Kecepatan gerakan
    public float speed = 2f;

    // Tinggi gerakan naik turun
    public float height = 0.2f;

    // Besar goyangan
    public float angle = 10f;

    // Posisi awal dumpling
    private Vector3 startPos;

    // Rotasi awal dumpling
    private Quaternion startRotation;

    // Berjalan sekali saat game dimulai
    void Start()
    {
        // Menyimpan posisi awal
        startPos = transform.position;

        // Menyimpan rotasi awal
        startRotation = transform.rotation;
    }

    // Berjalan terus setiap frame
    void Update()
    {
        // Gerakan naik turun
        float moveY = Mathf.Sin(Time.time * speed) * height;

        // Gerakan goyang kanan kiri
        float rotationZ = Mathf.Sin(Time.time * speed) * angle;

        // Mengatur posisi
        transform.position = startPos + new Vector3(0, moveY, 0);

        // Mengatur rotasi
        transform.rotation = startRotation * Quaternion.Euler(0, 0, rotationZ);
    }
}