using UnityEngine;

public class SmoothRotation : MonoBehaviour, Turnable
{
    [SerializeField] private float turnSmoothTime;
    private float currentAngle;
    private float turnSmoothVelocity;

    public void Turn(float angle)
    {
        currentAngle = Mathf.SmoothDampAngle(transform.eulerAngles.y, angle, ref turnSmoothVelocity, turnSmoothTime);
        transform.eulerAngles = new Vector3(0, currentAngle, 0);
    }

}