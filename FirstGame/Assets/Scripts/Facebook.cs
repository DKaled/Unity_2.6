using UnityEngine;

public class Facebook : MonoBehaviour
{
    void Start()
    {
        
    }

    public void FacebookFn()
    {
        Application.OpenURL("https://www.facebook.com/");
    }
}