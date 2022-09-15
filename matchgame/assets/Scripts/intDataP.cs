using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class IntDataP : ScriptableObject
{
    public int value;

    public void SetValue(int num)
    {
        value = num;
    }

    public void UpdateValue(int num)
    {
        value += num;
    }
}