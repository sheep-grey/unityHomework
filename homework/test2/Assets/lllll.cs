using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move1 : MonoBehaviour
{
    int colorIndex;
    float timer;
    Color[] colors = new Color[] { Color.red, Color.yellow, Color.green, Color.white, Color.gray };

    void Update()
    {
        timer += Time.deltaTime;
    }

    private void OnTriggerStay(Collider other)
    {
        Material selfMat = GetComponent<MeshRenderer>().material;
        selfMat.color = colors[colorIndex];

        if (timer > 0.5f)
        {
            colorIndex++;
            timer = 0;
        }

        if (colorIndex == colors.Length)
        {
            colorIndex = 0;
        }
    }
}