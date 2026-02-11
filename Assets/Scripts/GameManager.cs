using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static bool BallOut = false;

    public static int Score = 0;

    public Transform spawnPoint;

    public GameObject ballPrefab;

    public Text txt;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = "Score: " + Score;
        if (BallOut == false)
        {
            Instantiate(ballPrefab, spawnPoint.position, Quaternion.identity);
            BallOut = true;
        }

    }
}
