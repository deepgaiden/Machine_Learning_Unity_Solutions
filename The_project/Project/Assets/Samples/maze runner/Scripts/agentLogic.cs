using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Sensors;


public class agentLogic : Agent
{

    Rigidbody rig;


    public override void Initialize() 
    {
        rig = GetComponent<Rigidbody>();
    }

    public override void CollectObservations(VectorSensor sensor)
    {
        base.CollectObservations(sensor);
    }

    public override void OnActionReceived(float[] vectorAction)
    {
        base.OnActionReceived(vectorAction);
    }

    public override void Heuristic(float[] actionsOut)
    {
        base.Heuristic(actionsOut);
    }

    public override void OnEpisodeBegin()
    {
        base.OnEpisodeBegin();
    }


}
