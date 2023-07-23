using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class ShieldState : State
{
    [SerializeField] private float _shieldActiveTime;

    private float _currentTime = 0;
    private Animator _animator;
    private Enemy _enemy;

    private void OnEnable()
    {
        Debug.Log("Enable");

        _enemy = GetComponent<Enemy>();
        _animator = GetComponent<Animator>();
        _animator.Play("Shield");
    }

    private void Update()
    {
        _currentTime += Time.deltaTime;

        if( _shieldActiveTime <= _currentTime)
        {
            _enemy.SetsShieldState(false);
            _currentTime = 0;
        }
    }
}
