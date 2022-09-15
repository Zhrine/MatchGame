using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class TextMeshProBehavior : MonoBehaviour
{
    private TextMeshProUGUI label;
    public UnityEvent startEvent;

    private void Start()
    {
        label = GetComponent<TextMeshProUGUI>();
        startEvent.Invoke();
        
    }

    public void UpdateLabel(FloatDataP obj)
    {
        label.text = obj.value.ToString(CultureInfo.InvariantCulture);
    }
    public void UpdateLabel(IntDataP obj)
    {
        label.text = obj.value.ToString(CultureInfo.InvariantCulture);
    }
}
