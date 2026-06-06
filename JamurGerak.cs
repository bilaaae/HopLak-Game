using UnityEngine; // Memakai fitur Unity

public class JamurGerak : MonoBehaviour
{
    // Kecepatan goyangan jamur
    public float speed = 2f;

    // Besar goyangan jamur
    public float angle = 10f;

    // Menyimpan rotasi awal jamur
    private Quaternion startRotation;

    // Berjalan sekali saat game dimulai
    void Start()
    {
        // Menyimpan rotasi awal object jamur
        startRotation = transform.rotation;
    }

    // Berjalan terus setiap frame
    void Update()
    {
        // Membuat jamur goyang kanan kiri
        float rotationZ = Mathf.Sin(Time.time * speed) * angle;

        // Memutar jamur sedikit
        transform.rotation = startRotation * Quaternion.Euler(0, 0, rotationZ);
    }
}