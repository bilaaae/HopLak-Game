using UnityEngine;
// memanggil fitur dasar Unity (objek, collider, fisika, dll)

public class DeathZone : MonoBehaviour
// membuat script bernama DeathZone yang bisa ditempel di objek
{
    void OnTriggerEnter2D(Collider2D other)
    // fungsi ini jalan saat ada objek masuk ke area trigger (bawah / lava)
    {
        if (other.CompareTag("Player"))
        // cek apakah objek yang masuk adalah Player
        {
            HealthSystem.instance.KurangiNyawa();
            // kurangi nyawa pakai instance lalu mengurangi nyawa 1

            other.transform.position = Vector3.zero;
            // mengembalikan posisi player ke titik awal (0,0,0)
        }
    }
}