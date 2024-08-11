using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelText : MonoBehaviour
{
    public TMP_Text level;
    // Start is called before the first frame update
    void Start()
    {
        level.text = ("Level: " + PlayerPrefs.GetFloat("Level"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
