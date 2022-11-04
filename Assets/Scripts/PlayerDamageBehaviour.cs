using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageEvents
{
    int OnPlayerDamage();
}

public class PlayerDamageBehaviour : MonoBehaviour, IDamageEvents
{
    public int DamageAmount = 1;

    public int OnPlayerDamage()
    {
        return DamageAmount;
    }
}
