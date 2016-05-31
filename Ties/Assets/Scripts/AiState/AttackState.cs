using UnityEngine;
using System.Collections;

public class AttackState : EnemyState
{
    bool canAtk;
    float AtkTime;
    private readonly PatternState enemy;
    
    public AttackState(PatternState patternStateEnemy)
    {

        enemy = patternStateEnemy;
        
    }


    public void UpdateState()
    {
        Search();
        attack();
    }

    public void toPatrol()
    {

    }

    public void toIdle()
    {


    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        { toChase(); }

    }
    public void toChase()
    {
        enemy.currentState = enemy.chaseState;

    }

    public void toAttack()
    {



    }


    private void Search()
    {
        enemy.chaseTarget = GameObject.FindWithTag("Player").transform;
        RaycastHit hit;
        if (Physics.Raycast(enemy.eyes.transform.position, enemy.eyes.transform.forward, out hit, enemy.sightRange) && hit.collider.CompareTag("Player"))
        {
            enemy.chaseTarget = hit.transform;
            toChase();
        }

    }

    private void attack()
    {
        AtkTime += Time.deltaTime;

        if(AtkTime > 1 )
        {
            canAtk = true;
        }
        else { canAtk = false; }



        if (Vector3.Distance(enemy.navMeshAgent.destination, enemy.chaseTarget.position) < 1f && canAtk == true)
        {
            canAtk = false;
            enemy.warrior.damageTaken += 1;
            AtkTime = 0;
        }
        else { enemy.warrior.damageTaken += 0; }
       
    }

}
