using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour
{
    private void Awake() => SetDestroyOnLoadProperty();

    private void SetDestroyOnLoadProperty()
    {
        transform.parent = null;
        DontDestroyOnLoad(gameObject);
    }
}
