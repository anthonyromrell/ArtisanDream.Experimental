using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "Hunt", menuName = "Ai/Function/Patrol")]
public class AiPatrol : AiBase
{
    public UnityEvent NextPatrol;
    public UnityEvent EndPatrol;

    private int i = 0;

    private Coroutine coroutine;
    public GameAction AddPointsToList;
    public GameAction AddPointList;
    public float distance = 0;
    public float HoldTime = 0.1f;

    public List<PatrolPoint> PatrolPoints { get; set; }

    private void OnEnable()
    {
        PatrolPoints.Clear();
        if (AddPointsToList != null) AddPointsToList.Raise += AddPatrolPoints;
        if (AddPointList != null) AddPointList.Raise += AddPatrolPointList;
        i = 0;
    }

    private void Transfer(Coroutine c)
    {
        coroutine = c;
    }

    private void AddPatrolPoints(object obj)
    {
        PatrolPoints.Add(obj as PatrolPoint);
    }

    private void AddPatrolPointList(object obj)
    {
        PatrolPoints = obj as List<PatrolPoint>;
    }

    public override IEnumerator Nav(NavMeshAgent ai)
    {
        yield return new WaitForSeconds(HoldTime);
        ai.SetDestination(PatrolPoints[i].Value);
        var canRun = true;
        while (canRun)
        {
            yield return new WaitForFixedUpdate();
            if ((ai.remainingDistance <= distance))
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
                    yield return new WaitForSeconds(HoldTime);
                    EndPatrol.Invoke();
                }
            }
        }
    }
}