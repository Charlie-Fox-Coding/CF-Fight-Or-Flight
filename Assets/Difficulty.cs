using UnityEngine;

public class Difficulty : MonoBehaviour
{
    public float difficulty;
    public float Level;

    public void Start()
    {
        LoadLevel();
        SaveLevel(Level + 1.0f);
    }

    public void SaveDifficulty(float value)
    {
        PlayerPrefs.SetFloat("Difficulty", value);
        PlayerPrefs.Save();
    }

    public void LoadDifficulty()
    {
        difficulty = PlayerPrefs.GetFloat("Difficulty", 1.0f);
    }

    public void SaveLevel(float value)
    {
        PlayerPrefs.SetFloat("Level", value);
        PlayerPrefs.Save();
    }

    public void LoadLevel()
    {
        Level = PlayerPrefs.GetFloat("Level", 1.0f);
    }
}
