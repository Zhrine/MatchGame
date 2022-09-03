
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
//named with the _P for personal since we have a Submodule inside currently and i need the practice


public class FloatDataP : ScriptableObject
{
    public UnityEvent onZeroEvent;
    
    public float value;

    public void UpdateValue(float number)
    {
        value += number;
    }
    
}

