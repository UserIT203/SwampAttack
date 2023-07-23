using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _heatlh;
    [SerializeField] private int _reward;

    private Player _target;

    public Player Target => _target;
    public int Reward => _reward;

    public bool IsShield { get; private set; }

    public event UnityAction<Enemy> Dying;

    public void Init(Player target)
    {
        _target = target;
    }

    public bool SetsShieldState(bool active) => IsShield = active;

    public void TakeDamage(int damage)
    {
        _heatlh -= damage;

        if(_heatlh <= 0)
        {
            Dying?.Invoke(this);
            Destroy(gameObject);
        }
    }
}
