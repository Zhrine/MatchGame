using UnityEngine;
using UnityEngine.Events;

public class GameActionHandler : MonoBehaviour
{
    public GameAction gameActionObj;
    public UnityEvent onRaiseEvent;
    
    private void Start()
    {
        gameActionObj.raise += Raise;
    }//when this is called
    // The function below will be called 
    private void Raise()
    {
        onRaiseEvent.Invoke();
    }
}
