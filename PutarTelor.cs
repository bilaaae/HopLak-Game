using UnityEngine; // Memakai fitur Unity

public class PutarTelor : MonoBehaviour
{
    // Kecepatan gerakan putar
    public float speed = 3f;

    // Besar putaran
    public float rotationAmount = 20f;

    // Berjalan terus menerus
    void Update()
    {
        // Membuat telor berputar kanan kiri
        float rotationZ = Mathf.Sin(Time.time * speed) * rotationAmount;

        // Mengatur rotasi telor
        transform.rotation = Quaternion.Euler(0, 0, rotationZ);
    }
}