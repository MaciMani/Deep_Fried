using UnityEditor;
using UnityEngine.UIElements;

[CustomEditor(typeof(Interactions), true)]
public class InteractionsEditor : Editor
{
    public override void OnInspectorGUI()
    {
        Interactions interactions = (Interactions)target;
        if (target.GetType() == typeof(EventOnlyInteraction))
        {
            interactions.promptMessage = EditorGUILayout.TextField("prompt message", interactions.promptMessage);
            EditorGUILayout.HelpBox("EventOnlyInteraction can ONLY use UnityEvents",MessageType.Info);
            if(interactions.GetComponent<InteractionEvent>() == null) 
            {
                interactions.useEvents = true;
                interactions.gameObject.AddComponent<InteractionEvent>();
            }
        }
        else
        {
            base.OnInspectorGUI();
            if (interactions.useEvents)
            {
                //using event = add component
                if (interactions.GetComponent<InteractionEvent>() == null)
                    interactions.gameObject.AddComponent<InteractionEvent>();
            }
            else
            {
                //not using event = remove component
                if (interactions.GetComponent<InteractionEvent>() != null)
                    DestroyImmediate(interactions.GetComponent<InteractionEvent>());
            }
        }
    }
    
}
