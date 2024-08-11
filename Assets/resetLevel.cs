using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetFloat("Level", 1f);
        PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
