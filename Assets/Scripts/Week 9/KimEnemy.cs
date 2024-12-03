using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimEnemy : BaseEnemy
{
    public float minAttackDistance = 4.0f;

    public Transform target;

    // Start is called before the first frame update

    protected override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }

    protected override void Attack()
    {
        if (Vector3.Distance(transform.position, target.position) < minAttackDistance)
        {
            base.Attack();
            Debug.Log(this.gameObject.name + " deals " + attackDamage + " damage to you!");
            attackSfx.Play();
        }
    }

    public override void TakeDamage(float damage)
    {
        base.TakeDamage(damage);
        damageSfx.Play();
    }
}
