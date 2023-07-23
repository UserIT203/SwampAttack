using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ShieldTransition : Transition
{
    [SerializeField] private float _delay;
    [SerializeField] private float _rangeTime;

    private Enemy _enemy;
    private float _currentTime = 0;

    private void Start()
    {
        _enemy = GetComponent<Enemy>();
        _delay += Random.Range(-_rangeTime, _rangeTime);
    }

    private void Update()
    {
        _currentTime += Time.deltaTime;

        if (_delay <= _currentTime)
        {
            _enemy.SetsShieldState(true);
            NeedTransit = true;

            _currentTime = 0;
        }
    }
}
