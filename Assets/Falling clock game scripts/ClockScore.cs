using UnityEngine;

public class ClockScore : MonoBehaviour
{
    public int goalScore = 30;
    public int playerScore = 0;
    [SerializeField]
    Transform handPivot;
    public LogicScriptFallingClocks logic;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScriptFallingClocks>();
    }

    // Update is called once per frame
    void Update()
    {
        playerScore = logic.getScore();
        float degreeSteps = 360 / goalScore;
        handPivot.localRotation = Quaternion.Euler(0, 0, -degreeSteps * playerScore);
    }
}
