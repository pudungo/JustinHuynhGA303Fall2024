using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeEnemy : BaseEnemy
{
    public float minAttackDistance = 5.0f;

    public Transform target;
    
    // Start is called before the first frame update

    protected override void Start()
    {
        base.Start();

        Debug.Log("HeeHo I'm a slime!");
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }

    protected override void Attack()
    {
        if(Vector3.Distance(transform.position, target.position) < minAttackDistance)
        {
            base.Attack();
            Debug.Log(this.gameObject.name + " deals " + attackDamage + " damage to you!");
        }
    }

    public override void TakeDamage(float damage)
    {
        base.TakeDamage(damage);
    }
}
