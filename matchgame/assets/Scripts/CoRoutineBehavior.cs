using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CoRoutineBehavior : MonoBehaviour
{
    public UnityEvent startEvent, startCountEvent, repeatCountEvent, endCountEvent, repeatUntilFalseEvent;

    public bool canRun;
    public IntDataP counterNum;
    public float seconds = 3.0f;
    private WaitForSeconds _wfsObj;
    private WaitForFixedUpdate _wffuObj;

    public void Start()
    {
        startEvent.Invoke();
    }
    
    public void StartCounting()
    {
        StartCoroutine(Counting());
    }

    private IEnumerator Counting()
    {
        
        _wfsObj = new WaitForSeconds(seconds);
        _wffuObj = new WaitForFixedUpdate();
        
        startCountEvent.Invoke();
        yield return _wfsObj;
        while (counterNum.value > 0)
        {
            repeatCountEvent.Invoke();
            counterNum.value--;
            yield return _wfsObj;

        }
        endCountEvent.Invoke();
    }

    public void StartRepeatUntilFalse()
    {
        canRun = true;
        StartCoroutine(RepeatUntilFalse());
    }

    private IEnumerator RepeatUntilFalse()
    {
        while (canRun)
        {
            yield return _wfsObj;    
            repeatUntilFalseEvent.Invoke();
        }
    }
}
