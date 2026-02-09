using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool BallOut = false;

    public Transform spawnPoint;

    public GameObject ballPrefab;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (BallOut == false)
        {
            Instantiate(ballPrefab, spawnPoint.position, Quaternion.identity);
            BallOut = true;
        }
    }
}
