using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
public class Move2 : MonoBehaviour
{
    public GameObject prefab;
    float SpeedTarget = 500;
    public Transform StartPosision;
    float TimeToChangeDirection = 5.0f;
    float Speed = 2;
    Transform Player;
    public NavMeshAgent agent;
    Transform En;
    float heading;
    float TimeToShoot = 2.0f;
    public int Health = 5;
    float distance = 1.0f;



    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        En = this.gameObject.transform;

        agent = GetComponent<NavMeshAgent>();
        agent.speed = Speed;
    }


    void FixedUpdate()
    {
        transform.Translate(0, 0, Speed * Time.deltaTime);

        TimeToChangeDirection -= Time.deltaTime;
        TimeToShoot -= Time.deltaTime;

        Ray checkRay = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Player != null) {
            heading = (Player.position - En.position).sqrMagnitude;
            if (heading < 75)
            {
                Vector3 PosToLook = Player.position - En.position;
                transform.rotation = Quaternion.LookRotation(PosToLook);
                agent.SetDestination(Player.position);
                if (TimeToShoot < 0)
                {
                    StartCoroutine(Attack());
                    TimeToShoot = 2;
                }
            }
            else if (Physics.SphereCast(checkRay, 0.75f, out hit) || TimeToChangeDirection <= 0)
            {
                if(TimeToChangeDirection <= 0 || hit.distance <= distance)
                {
                    float angl = Random.Range(-180, 180);
                    transform.Rotate(0, angl, 0);
                    TimeToChangeDirection = 5.0f;
                }
            }
        }
    }

    IEnumerator Attack()
        {
            GameObject go = Instantiate(this.prefab, this.StartPosision.position, Quaternion.identity) as GameObject;
            go.transform.forward = this.StartPosision.forward;
            go.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * SpeedTarget);
            Destroy(go, 10);

            yield return new WaitForSeconds(4.0f);
        }
        
}
