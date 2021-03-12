using ScriptableArchitecture.Variables;
using UnityEditor;
using UnityEngine;

namespace ScriptableArchitecture.Editor
{
    /// <summary>
    /// A property drawer for reference variables.
    /// </summary>
    [CustomPropertyDrawer(typeof(IntReference), true)]
    public sealed class ReferenceProperty : PropertyDrawer
    {
        #region PropertyDrawer Implementation
        /// <summary>
        ///   <para>Override this method to make your own IMGUI based GUI for the property.</para>
        /// </summary>
        /// <param name="position">Rectangle on the screen to use for the property GUI.</param>
        /// <param name="property">The SerializedProperty to make the custom GUI for.</param>
        /// <param name="label">The label of this property.</param>
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            /*
             * nameof(Reference._useConstant) would be a more maintainable alternative to a string binding,
             * however, nameof may not always be available in a given C# feature set. Unity 2020.1 also provides
             * a different way to serialize generics for property drawers, which circumvents this issue. In the
             * name of backwards compatibility, however, ScriptableArchitecture is (at least for now) built
             * using this ugly string binding.
             */
            // Stores whether the Reference uses a constant or not
            bool useConstant = property.FindPropertyRelative("_useConstant").boolValue;
            
            // Begins drawing the property
            EditorGUI.BeginProperty(position, label, property);

            // Draws property label
            position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);
            
            // Draws a dropdown button to select constant or reference modes right beside the field
            Rect buttonRect = new Rect(position.position - new Vector2(17f, -2f), Vector2.one * 20f);
            
            // Dropdown button functionality
            DropdownMenuFunctionality(buttonRect, useConstant, property);
            
            // Draws the field
            DrawField(useConstant, position, property);
            
            EditorGUI.EndProperty();
        }

        /// <summary>
        ///   <para>Override this method to specify how tall the GUI for this field is in pixels.</para>
        /// </summary>
        /// <param name="property">The SerializedProperty to make the custom GUI for.</param>
        /// <param name="label">The label of this property.</param>
        /// <returns>
        ///   <para>The height in pixels.</para>
        /// </returns>
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return base.GetPropertyHeight(property, label);
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Executes the functionality related to the dropdown menu
        /// </summary>
        private void DropdownMenuFunctionality(Rect dropdownButtonRect, bool useConstant, 
            SerializedProperty property)
        {
            // The bool on whether the button is being clicked or not.
            // Also creates the button
            bool dropDownButton = EditorGUI.DropdownButton(dropdownButtonRect,
                // Sets the button's texture
                new GUIContent(EditorGUIUtility.FindTexture("_Menu")),
                // Makes the button capture keyboard on click
                FocusType.Keyboard,
                // Creates button area
                new GUIStyle() {fixedHeight = 50f, border = new RectOffset(1, 1, 1, 1)});
            
            // If the button has been clicked
            if (dropDownButton)
            {
                // Creates dropdown menu
                GenericMenu dropdownMenu = new GenericMenu();
                
                // Adds items to the menu
                // Constant
                dropdownMenu.AddItem(new GUIContent("Constant"), useConstant,
                    () => SetConstantProperty(property, true));
                // Variable
                dropdownMenu.AddItem(new GUIContent("Reference"), !useConstant,
                    () => SetConstantProperty(property, false));
                
                dropdownMenu.ShowAsContext();
            }
        }

        /// <summary>
        /// Sets the a value in the serialized property
        /// </summary>
        /// <param name="property">The serialized property to set the value to</param>
        /// <param name="value">The value to be set</param>
        private void SetConstantProperty(SerializedProperty property, bool value)
        {
            // Caches the relative property
            SerializedProperty relativeProperty = property.FindPropertyRelative("_useConstant");

            // Changes value and saves
            relativeProperty.boolValue = value;
            property.serializedObject.ApplyModifiedProperties();
        }

        /// <summary>
        /// Draws a field for the property
        /// </summary>
        /// <param name="useConstant">Whether the property is constant or not</param>
        /// <param name="position">The position of the field</param>
        /// <param name="property">The property</param>
        private void DrawField(bool useConstant, Rect position, SerializedProperty property)
        {
            int value = property.FindPropertyRelative("_constant").intValue;
            
            if (useConstant)
            {
                property.FindPropertyRelative("_constant").intValue = EditorGUI.IntField(position, value);
            } 
            else
            {
                EditorGUI.ObjectField(position, property.FindPropertyRelative("_variable"), GUIContent.none);
            }
        }
        #endregion
    }
}