using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTracker : MonoBehaviour
{

    static LevelTracker Instance;
    public static int levelsBeaten = 0;

    public GameObject level2Block;
    public GameObject level3Block;
    public GameObject WinBlock;

    // Start is called before the first frame update
    void Start()
    {
        if (Instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
        }

        DontDestroyOnLoad(gameObject);

        if (levelsBeaten >= 1)
        {
            Destroy(level2Block);
        }

        if (levelsBeaten >= 2)
        {
            Destroy(level3Block);
        }

        if (levelsBeaten >= 3)
        {
            Destroy(WinBlock);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
