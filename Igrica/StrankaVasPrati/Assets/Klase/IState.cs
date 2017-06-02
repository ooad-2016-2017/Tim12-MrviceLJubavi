using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState {
    void Handle(Stickman s);
}
public class StateJump : IState
{
    public void Handle (Stickman s)
    {
        s.Y = 4.5F;
        s.Skok = true;
    }
}
public class StateNormal : IState
{
    public void Handle (Stickman s)
    {
        s.Y = 0;
        s.Skok = false;
    }
}
