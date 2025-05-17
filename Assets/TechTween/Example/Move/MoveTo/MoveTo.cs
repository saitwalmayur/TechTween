using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTo : MonoBehaviour
{
    public Vector3 position;
    public float time;
    public EaseTween easeTween;
    public bool pingpong;
    public bool loop;
    public int loopCount = 1;
    private void OnEnable()
    {
        TechTween.MoveTo(gameObject, position, time)
            .SetEaseType(easeTween)
            .SetPingPong(pingpong)
            .SetInfiniteLoop(loop)
            .SetLoopCount(loopCount);
    }
}
