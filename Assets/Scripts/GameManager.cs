using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int enemyKilled;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instance = this;
        enemyKilled = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
