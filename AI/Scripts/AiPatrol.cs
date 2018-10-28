using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "Patrol", menuName = "Ai/Function/Patrol")]
public class AiPatrol : AiBase
{
    public UnityEvent NextPatrol;
    public UnityEvent EndPatrol;

    private int i = 0;

    [HideInInspector]
    public GameAction SendCoroutine;
    public GameAction AddPointsToList;
    public GameAction AddPointList;
    public FloatData distance;
    public FloatData HoldTime;

    public List<Vector3Data> PatrolPoints { get; set; }

    private void OnEnable()
    {
        PatrolPoints.Clear();
        if (AddPointsToList != null) AddPointsToList.Raise += AddPatrolPoints;
        if (AddPointList != null) AddPointList.Raise += AddPatrolPointList;
        i = 0;
        NextPatrol.AddListener(RestartPatrol);
    }

    private void AddPatrolPoints(object obj)
    {
        PatrolPoints.Add(obj as Vector3Data);
    }

    private void AddPatrolPointList(object obj)
    {
        PatrolPoints = obj as List<Vector3Data>;
    }

    public void RestartPatrol()
    {
        SendCoroutine.RaiseNoArgs();
    }
    
    public override IEnumerator Nav(NavMeshAgent ai)
    {
        yield return new WaitForSeconds(HoldTime.Value);
        ai.SetDestination(PatrolPoints[i].Value);
        var canRun = true;
        while (canRun)
        {
            yield return new WaitForFixedUpdate();
            if ((ai.remainingDistance <= distance.Value))
            {
                if (i < PatrolPoints.Count - 1)
                {
                    i++;
                    canRun = false;
                    NextPatrol.Invoke();
                }
                else
                {
                    i = 0;
                    canRun = false;
                    yield return new WaitForSeconds(HoldTime.Value);
                    EndPatrol.Invoke();
                }
            }
        }
    }
}