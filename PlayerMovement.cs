using UnityEngine;
// memanggil fitur Unity seperti physics, input, dan animator

public class PlayerMovement : MonoBehaviour
// script untuk mengatur gerakan dan animasi player
{
    public float speed = 5f;
    // kecepatan gerak kiri kanan

    public float jumpForce = 7f;
    // kekuatan lompat player

    Rigidbody2D rb;
    // komponen physics player

    Animator anim;
    // komponen animator player

    int jumpCount = 0;
    // menghitung jumlah lompat player

    public int maxJump = 2;
    // maksimal jumlah lompat (double jump)

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // mengambil Rigidbody2D dari player

        anim = GetComponent<Animator>();
        // mengambil Animator dari player
    }

    void Update()
    {
        float move = Input.GetAxisRaw("Horizontal");
        // mengambil input kiri kanan dari keyboard

        rb.linearVelocity = new Vector2(move * speed, rb.linearVelocity.y);
        // menggerakkan player ke kiri dan kanan

        // flip karakter kanan kiri
        if (move > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
            // hadap kanan
        }
        else if (move < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            // hadap kiri
        }

        anim.SetFloat("Speed", Mathf.Abs(move));
        // mengganti animasi idle dan run berdasarkan gerakan

        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < maxJump)
        // jika tombol spasi ditekan dan jumlah lompat belum melebihi batas
        {
            rb.linearVelocity = Vector2.zero;
            // reset velocity supaya jatuh tidak kebawa saat lompat

            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            // memberi dorongan ke atas agar player lompat

            jumpCount++;
            // menambah jumlah lompat

            anim.SetBool("IsJumping", true);
            // mengaktifkan animasi lompat
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    // dijalankan saat player menyentuh object lain
    {
        if (collision.gameObject.CompareTag("Ground"))
        // jika menyentuh object dengan tag Ground
        {
            jumpCount = 0;
            // reset jumlah lompat

            anim.SetBool("IsJumping", false);
            // kembali ke animasi idle/run

            rb.linearVelocity = new Vector2(rb.linearVelocity.x, 0);
            // menghentikan jatuh berlebihan saat mendarat
        }
    }
}