using UnityEngine;
using UnityEngine.UI;
public class CubeRotation : MonoBehaviour
{
    public Slider slider;
    public Text rotationSpeedText;
    public float minRotationSpeed = 90f;
    public float maxRotationSpeed = 450f;
    private float currentRotationSpeed;
    void Start()
    {
        slider.onValueChanged.AddListener(delegate { ChangeRotationSpeed(); });
    }
    void Update()
    {
        transform.Rotate(0, currentRotationSpeed * Time.deltaTime, 0);
        rotationSpeedText.text = "Rotation Speed: " + currentRotationSpeed.ToString() + " degrees per second";
    }
    void ChangeRotationSpeed()
    {
        if (slider.value == slider.minValue)
        {
            currentRotationSpeed = minRotationSpeed;
            slider.value = slider.maxValue;
        }
        else if (slider.value == slider.maxValue)
        {
            currentRotationSpeed = maxRotationSpeed;
            slider.value = slider.minValue;
        }
        else
        {
            currentRotationSpeed = minRotationSpeed;
            slider.value = slider.minValue;
        }
    }
}
