using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IObserver {
    void Update1(Stickman s);
    void Update5(Stickman s);
}
public class Observer : IObserver
{
    public void Update1 (Stickman s)
    {
        s.Score++;
    }
    public void Update5 (Stickman s)
    {
        s.Score += 5;
    }
}