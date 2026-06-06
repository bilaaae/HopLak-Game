using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    // supaya bisa dipanggil dari script lain

    public TMP_Text teksScore;
    // tampilan score di UI

    int score = 0;
    // nilai awal score

    void Awake()
    {
        instance = this;
        // bikin akses global
    }

    public void TambahScore(int nilai)
    {
        score += nilai;
        // tambah score

        teksScore.text = "Score: " + score;
        // update tampilan
    }
}