using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

public class WorldGUIController : MonoBehaviour
{
    private VisualElement _root;
    private ProgressBar _health;
    
    private void Awake()
    {
        _root = GetComponent<UIDocument>().rootVisualElement;

        _health = _root.Q<ProgressBar>("Health");
        _health.value = 100;
    }
}
