using UnityEngine;

public class SetAction : MonoBehaviour
{
    public string currentAction = "";

    public void AssignJumpAction()
    {
        currentAction = "Jump";
        Debug.Log("Acción asignada: " + currentAction);
    }

    public void AssignFlyAction()
    {
        currentAction = "Fly";
        Debug.Log("Acción asignada: " + currentAction);
    }

    public void NoAction()
    {
        if (string.IsNullOrEmpty(currentAction))
        {
            Debug.Log("No tiene ninguna acción asignada");
        }
        else
        {
            Debug.Log("Acción actual: " + currentAction);
        }
    }
}