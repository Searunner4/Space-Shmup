// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// [RequireComponent(typeof(EnemyShield))]
// public class Enemy_4 : Enemy
// {
//     private EnemyShield[] allShields;
//     private EnemyShield thisShield;
//     // Start is called before the first frame update
//     void Start()
//     {
//         allShields = GetComponentsInChildren<EnemyShield>();
//         thisShield = GetComponent<EnemyShield>();
//     }

//     public override void Move()
//     {
//         //More will be added here later, for now it will be easier if Enemy_4 doesn't move
//     }

//     ///<summary>
//     ///Enemy_4 Collisions are handled differently from other Enemy subclasses
//     ///     to enable protection by EnemyShields.
//     ///</summary>
//     /// <param name="coll"></param>
//     void OnCollisionEnter(Collision coll)
//     {
//         GameObject otherGO = coll.gameObject;

//         //Make sure this was hit by a ProjectileHero
//         ProjectileHero p = otherGO.GetComponent<ProjectileHero>();
//         if(p != null)
//         {
//             //Destory the ProjectileHero regardless of bndCheck.isOnScreen
//             Destroy(otherGO);

//             //Only damage this Enemy if it's on screen
//             if(bndCheck.isOnScreen)
//             {
//                 //Find the GameObject of this Enemy_4 that was actually hit
//                 GameObject hitGO = coll.contacts[0].otherCollider.gameObject;
//                 if(hitGO == otherGO)
//                 {
//                     hitGO = coll.contacts[0].otherCollider.gameObject;
//                 }

//                 //Get the damage amout from the Main WEAP_DICT
//                 float dmg = Main.GET_WEAPON_DEFINITION(p.type).damageOnHit;

//                 //Find the EnemyShield that was hit (if there was one)
//                 bool shieldFound = false;
//                 foreach(EnemyShield es in allShields)
//                 {
//                     if(es.gameObject == hitGO)
//                     {
//                         es.TakeDamage(dmg);
//                         shieldFound = true;
//                     }
//                 }
//                 if(!shieldFound) thisShield.TakeDamage(dmg);

//                 //If thisShield is still active, then it has not been destroyed
//                 if(thisShield.isActive) return;

//                 //This ship was destroyed so tell Main about it
//                 if(!calledShipDestroyed)
//                 {
//                     Main.SHIP_DESTROYED(this);
//                     calledShipDestroyed = true;
//                 }
                
//                 //Destroy this Enemy_4
//                 Destroy(gameObject);
//             }
//         }
//     }
// }
