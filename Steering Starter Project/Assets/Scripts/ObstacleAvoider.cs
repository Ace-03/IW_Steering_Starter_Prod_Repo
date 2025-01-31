public class ObstacleAvoider : Kinematic
{
    ObstacleAvoidance myMoveType;

    //public Kinematic[] myTargets = new Kinematic[4];

    // Start is called before the first frame update
    void Start()
    {
        myMoveType = new ObstacleAvoidance();
        myMoveType.character = this;
        myMoveType.target = myTarget;
    }

    // Update is called once per frame
    protected override void Update()
    {
        steeringUpdate = myMoveType.getSteering();
        base.Update();
    }
}
