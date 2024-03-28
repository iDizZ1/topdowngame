using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using project.Utils;
using Unity.PlasticSCM.Editor.WebApi;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] private State startingState; //начальное состо€ние
    [SerializeField] private float roamingDistanceMax = 7f; //макс рассто€ние перемещени€
    [SerializeField] private float roamingDistanceMin = 3f; //мин рассто€ние перемещени€
    [SerializeField] private float roamingTimerMax = 2f;    //врем€ перемещени€

    private NavMeshAgent navmeshAgent;
    private State state; //текущее состо€ние объекта
    private float roamingTime; //текущее врем€
    private Vector3 roamPosition;
    private Vector3 StartingPosition;

    private enum State //состо€ни€ в которых может пребывать объект
    {
        Roaming
    }

 
    private void Awake()
    {
        navmeshAgent = GetComponent<NavMeshAgent>();
        navmeshAgent.updateRotation = false;
        navmeshAgent.updateUpAxis = false;
        state = startingState;

    }

    private void Update()
    {
        switch (state)
        {
            default:
            case State.Roaming:
                roamingTime -= Time.deltaTime;
                if (roamingTime < 0)
                {
                    Roaming();
                    roamingTime = roamingTimerMax;
                }
                break;
        }
    }

    private void Roaming()
    {
        StartingPosition = transform.position;
        roamPosition = GetRoamPosition();
        ChangeFacingDirection(StartingPosition, roamPosition);
        navmeshAgent.SetDestination( roamPosition );
    }

    private Vector3 GetRoamPosition()
    {
        return StartingPosition + Utils.GetRandomDir() * UnityEngine.Random.Range(roamingDistanceMin, roamingDistanceMax); 
    }

    private void ChangeFacingDirection(Vector3 sourceposition, Vector3 targetposition)
    {
        if (sourceposition.x > targetposition.x)
        {
            transform.rotation = Quaternion.Euler(0, -180, 0);

        } 
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
