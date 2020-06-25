using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private float timeBtwAttack;
    public float startTimeBtwAttack;

    public Transform attackPos;
    public float attackRange;
    public LayerMask whatIsEnemies;
    public int damage;


    void Start()
    {
        
    }

    
    void Update()
    {
        if(timeBtwAttack <= 0) //you can attack
        {
            if (Input.GetKey(KeyCode.E))
            {
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemies); //array of enemies in a radius of a circle
                for (int i=0; i < enemiesToDamage.Length; i++)
                {
                    enemiesToDamage[i].GetComponent<EnemyScript>().TakeDamage(damage); //calls takeDamage on each enemy in array
                }
            }

            timeBtwAttack = startTimeBtwAttack;
        }
        else
        {
            timeBtwAttack -= Time.deltaTime;
        }
    }


    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }
}
