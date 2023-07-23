using UnityEngine;

public class MoveTransition : Transition
{
    private Enemy _enemy;

    private void OnEnable()
    {
        _enemy = GetComponent<Enemy>();
    }

    private void OnValidate()
    {
        if (_enemy != null)
            return;
    }

    private void Update()
    {
        if (Vector2.Distance(transform.position, Target.transform.position) > 0 && _enemy.IsShield == false)
        {
            NeedTransit = true;
        }
    }
}
