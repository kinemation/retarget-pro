using KINEMATION.KAnimationCore.Editor.Misc;
using KINEMATION.KAnimationCore.Runtime.Rig;
using UnityEditor;
using UnityEngine;

namespace Demo.Scripts
{
    [CustomEditor(typeof(TestAsset))]
    public class TestAssetEditor : Editor
    {
        private AssetObjectWidget<AvatarMask> _avatarMaskWidget;
        private AssetObjectWidget<KRig> _rigWidget;

        private Color _normal = new Color(59f / 256f, 59f / 256f, 59f / 256f);
        private Color _hovered = new Color(99f / 256f, 99f / 256f, 99f / 256f);

        private void OnEnable()
        {
            _avatarMaskWidget = new AssetObjectWidget<AvatarMask>(serializedObject, "avatarMask", "Avatar Mask");
            _rigWidget = new AssetObjectWidget<KRig>(serializedObject, "rig", "Rig");
        }

        public override void OnInspectorGUI()
        {
            _avatarMaskWidget.OnInspectorGUI();
            _rigWidget.OnInspectorGUI();
            base.OnInspectorGUI();

            var masterRect = EditorGUILayout.BeginVertical();

            for (int i = 0; i < 3; i++)
            {
                EditorGUILayout.BeginHorizontal();
                
                var rect = GUILayoutUtility.GetRect(masterRect.width, EditorGUIUtility.singleLineHeight);

                Color outlineColor = Color.black;//new Color(34f / 256f, 34f / 256f, 34f / 256f);
                float ratio = 0.9f;
                
                var rectA = rect;
                rectA.width *= ratio;

                var rectB = rect;
                rectB.x += rectA.width;
                rectB.width *= 1f - ratio;

                Rect outlineRect = rect;
                outlineRect.height = 1f;
            
                //EditorGUI.DrawRect(outlineRect, outlineColor);
                outlineRect.y += rect.height;
                //EditorGUI.DrawRect(outlineRect, outlineColor);
                
                outlineRect.width = 1f;
                outlineRect.height = -rect.height;
                
                //EditorGUI.DrawRect(outlineRect, outlineColor);
                outlineRect.x += rect.width - 1f;
                //EditorGUI.DrawRect(outlineRect, outlineColor);

                GUIStyle labelStyle = GUI.skin.box;
                labelStyle.alignment = TextAnchor.MiddleLeft;
                labelStyle.fontStyle = FontStyle.Bold;
                labelStyle.padding = new RectOffset(15, 2, 2, 2);

                var cachedColor = GUI.backgroundColor;

                if (rectA.Contains(Event.current.mousePosition) || rectB.Contains(Event.current.mousePosition))
                {
                    GUI.backgroundColor = _hovered;
                }
                else
                {
                    GUI.backgroundColor = _normal;
                }
                
                if (GUI.Button(rectA, "FPS Animator Type", labelStyle))
                {
                    
                }
                
                if (GUI.Button(rectB, "#", labelStyle))
                {
                }

                GUI.backgroundColor = cachedColor;

                outlineRect.x = rectB.x;
                outlineRect.width = 1;
                //EditorGUI.DrawRect(outlineRect, outlineColor);

                EditorGUILayout.EndHorizontal();
            }
            
            EditorGUILayout.EndVertical();
            
            Repaint();
        }
    }
}