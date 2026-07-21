using UnityEngine;
[CreateAssetMenu(fileName = "Dialogue", menuName = "Dialogue/Create New Dialogue")]
public class Dialogue : ScriptableObject
{
    [TextArea]
    public string reactionText;
}
