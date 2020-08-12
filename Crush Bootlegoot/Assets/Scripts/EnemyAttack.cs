using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    private float timeBtwAttack;
    public float startTimeBtwAttack;
    public Animator animator;

    public Transform attackPos;
    public float attackRange;
    public LayerMask whatIsEnemies;
    public int damage;
    private bool currentlyAttacking = false;


    void Start()
    {
        
    }

    
    void Update()
    {
        if (timeBtwAttack <= 0) //you can attack
        {
          
          Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemies); //array of enemies in a radius of a circle
          for (int i = 0; i < enemiesToDamage.Length; i++)
           {
                 enemiesToDamage[i].GetComponent<PlayerHP>().TakeDamage(damage); //calls takeDamage on each enemy in array
                //animator.SetTrigger("EnemyAttacks");
           }

           timeBtwAttack = startTimeBtwAttack;
           currentlyAttacking = true;
           animator.SetTrigger("EnemyAttacks");

        }
        else
        {
            timeBtwAttack -= Time.deltaTime;
        }

        if (timeBtwAttack <=0 && currentlyAttacking)
        {
            currentlyAttacking = false;
            animator.ResetTrigger("EnemyAttacks");
        }

    }
}
