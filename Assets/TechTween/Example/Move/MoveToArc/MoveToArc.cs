using UnityEngine;

public class MoveToArc : MonoBehaviour
{
    public Vector3 position;
    public Vector3 arcHeight;
    public float time;
    public EaseTween easeTween;
    private void OnEnable()
    {
        TechTween.MoveToArc(gameObject, position, arcHeight, time).SetEaseType(easeTween);
    }
}
