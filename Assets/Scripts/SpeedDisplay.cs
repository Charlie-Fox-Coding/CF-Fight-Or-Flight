using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedDisplay : MonoBehaviour
{
    public EnemyMovement enemy;
    public float BaseSpeed;
    public Slider mainSlider;
    public float Value;

    // Start is called before the first frame update
    void Start()
    {
        BaseSpeed = enemy.speed;
    }

    // Update is called once per frame
    void Update()
    {
        mainSlider.value = (1 - (3*(BaseSpeed - enemy.speed)));
        Value = mainSlider.value;
    }
}
