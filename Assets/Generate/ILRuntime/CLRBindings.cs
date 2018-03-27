using System;
using System.Collections.Generic;
using System.Reflection;

namespace ILRuntime.Runtime.Generated
{
    class CLRBindings
    {


        /// <summary>
        /// Initialize the CLR binding, please invoke this AFTER CLR Redirection registration
        /// </summary>
        public static void Initialize(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            System_Collections_Generic_List_1_UnityObject_Binding.Register(app);
            System_String_Binding.Register(app);
            UnityEngine_Debug_Binding.Register(app);
            System_Boolean_Binding.Register(app);
            UnityEngine_UI_InputField_Binding.Register(app);
            System_Runtime_CompilerServices_AsyncTaskMethodBuilder_1_String_Binding.Register(app);
            System_Runtime_CompilerServices_AsyncTaskMethodBuilder_Binding.Register(app);
            System_Threading_Tasks_Task_1_ILTypeInstance_Binding.Register(app);
            System_Runtime_CompilerServices_TaskAwaiter_1_ILTypeInstance_Binding.Register(app);
            System_Int64_Binding.Register(app);
            Core_TSingleton_1_OpcodeTypes_Binding.Register(app);
            Framework_Network_OpcodeTypes_Binding.Register(app);
            System_Object_Binding.Register(app);
            Core_DictExpand_Binding.Register(app);
            Core_Dict_2_UInt32_Action_1_Object_Binding.Register(app);
            System_Collections_Generic_List_1_Byte_Array_Binding.Register(app);
            System_Byte_Binding.Register(app);
            System_Threading_Tasks_TaskCompletionSource_1_ILTypeInstance_Binding.Register(app);
            Model_ASession_Binding.Register(app);
            System_Exception_Binding.Register(app);
            Framework_Network_Session_Binding.Register(app);
            System_Array_Binding.Register(app);
            System_IO_MemoryStream_Binding.Register(app);
            System_IO_BinaryReader_Binding.Register(app);
            System_IDisposable_Binding.Register(app);
            Core_WindJson_JsonNode_Binding.Register(app);
            System_IO_BinaryWriter_Binding.Register(app);
            UnityEngine_GameObject_Binding.Register(app);
            UnityEngine_Object_Binding.Register(app);
            Framework_WindUI_ViewContainer_Binding.Register(app);
            Framework_Hotfix_HotfixMBContainer_Binding.Register(app);
            System_Type_Binding.Register(app);
            Core_TSingleton_1_CoroutineManager_Binding.Register(app);
            Core_CoroutineManager_Binding.Register(app);
            Core_UtilTool_Binding.Register(app);
            System_NotSupportedException_Binding.Register(app);
            Framework_WindUI_UIRoot_Binding.Register(app);
            Core_IndexedDict_2_String_ILTypeInstance_Binding.Register(app);
            Core_Dict_2_String_ILTypeInstance_Binding.Register(app);
            System_Collections_Generic_List_1_String_Binding.Register(app);
            Core_IndexedDictExpand_Binding.Register(app);
            Core_CKeyValuePair_2_String_ILTypeInstance_Binding.Register(app);
            Framework_WindUI_UITool_Binding.Register(app);
            System_Guid_Binding.Register(app);
            Core_TSingleton_1_UIAssetLoader_Binding.Register(app);
            Framework_WindUI_UIAssetLoader_Binding.Register(app);
            System_Threading_Tasks_Task_Binding.Register(app);
            System_Runtime_CompilerServices_TaskAwaiter_Binding.Register(app);
            System_Threading_Tasks_Task_1_Framework_WindUI_UIAssetLoader_Binding_LoaderRequest_Binding.Register(app);
            System_Runtime_CompilerServices_TaskAwaiter_1_Framework_WindUI_UIAssetLoader_Binding_LoaderRequest_Binding.Register(app);
            Framework_WindUI_UIAssetLoader_Binding_LoaderRequest_Binding.Register(app);
            System_Collections_Generic_List_1_ILTypeInstance_Binding.Register(app);
            Core_Dict_2_Int32_ILTypeInstance_Binding.Register(app);
            UnityEngine_WaitForEndOfFrame_Binding.Register(app);
            Core_IEnumeratorAwaitExtensions_Binding.Register(app);
            Core_IEnumeratorAwaitExtensions_Binding_SimpleCoroutineAwaiter_Binding.Register(app);
            System_Collections_Generic_IEnumerator_1_CKeyValuePair_2_Int32_ILTypeInstance_Binding.Register(app);
            Core_CKeyValuePair_2_Int32_ILTypeInstance_Binding.Register(app);
            System_Collections_IEnumerator_Binding.Register(app);
            System_Int32_Binding.Register(app);
            System_Collections_Generic_List_1_CKeyValuePair_2_Int32_ILTypeInstance_Binding.Register(app);
            System_Reflection_ICustomAttributeProvider_Binding.Register(app);
            System_Collections_Generic_List_1_MemberInfo_Binding.Register(app);
            System_Reflection_MemberInfo_Binding.Register(app);
            System_Reflection_PropertyInfo_Binding.Register(app);
            System_Reflection_FieldInfo_Binding.Register(app);
            Core_WindJson_JsonParser_Binding.Register(app);
            Core_WindJson_JsonArray_Binding.Register(app);
            System_Collections_IEnumerable_Binding.Register(app);
            Core_WindJson_JsonClass_Binding.Register(app);
            System_Collections_IDictionary_Binding.Register(app);
            Core_IDict_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Object_Object_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Object_Object_Binding_Enumerator_Binding.Register(app);
            System_Collections_Generic_KeyValuePair_2_Object_Object_Binding.Register(app);
            Core_WindJson_JsonData_Binding.Register(app);
            Core_ReflectionAssist_Binding.Register(app);
            System_Reflection_ConstructorInfo_Binding.Register(app);
            System_Convert_Binding.Register(app);
            System_Collections_Hashtable_Binding.Register(app);
            System_Collections_Generic_List_1_Type_Binding.Register(app);
            System_Collections_Generic_List_1_KeyValuePair_2_Type_Type_Binding.Register(app);
            System_AppDomain_Binding.Register(app);
            System_Reflection_Assembly_Binding.Register(app);
            System_Collections_Generic_KeyValuePair_2_Type_Type_Binding.Register(app);
            System_Collections_Generic_List_1_KeyValuePair_2_Type_Type_Binding_Enumerator_Binding.Register(app);
            Framework_Hotfix_UnityObject_Binding.Register(app);
            Test_HotfixMBTest_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int32_Int32_Binding.Register(app);
            System_Collections_Generic_Dictionary_2_Int32_Int32_Binding_Enumerator_Binding.Register(app);
            System_Collections_Generic_KeyValuePair_2_Int32_Int32_Binding.Register(app);
            UnityEngine_Vector2_Binding.Register(app);
            Core_TSingleton_1_AvatarAssetLoader_Binding.Register(app);
            Framework_AvatarAssetLoader_Binding.Register(app);
            System_Threading_Tasks_Task_1_AvatarLoaderRequest_Binding.Register(app);
            System_Runtime_CompilerServices_TaskAwaiter_1_AvatarLoaderRequest_Binding.Register(app);
            Framework_AvatarLoaderRequest_Binding.Register(app);
            UnityEngine_Vector3_Binding.Register(app);
            UnityEngine_Transform_Binding.Register(app);
            System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Binding.Register(app);
            Core_TSingleton_1_SceneAssetLoader_Binding.Register(app);
            Framework_SceneAssetLoader_Binding.Register(app);
            Core_TSingleton_1_GameFlowLevelManager_Binding.Register(app);
            Framework_GameFlowLevelManager_Binding.Register(app);
            System_Threading_Tasks_Task_1_Framework_GameFlowLevelManager_Binding_LevelRequest_Binding.Register(app);
            System_Runtime_CompilerServices_TaskAwaiter_1_Framework_GameFlowLevelManager_Binding_LevelRequest_Binding.Register(app);
            Framework_GameLoading_Binding.Register(app);
            System_Threading_Tasks_Task_1_Framework_SceneAssetLoader_Binding_SceneLoaderRequest_Binding.Register(app);
            System_Runtime_CompilerServices_TaskAwaiter_1_Framework_SceneAssetLoader_Binding_SceneLoaderRequest_Binding.Register(app);
            System_IO_File_Binding.Register(app);
            Core_Dict_2_Int32_List_1_ILTypeInstance_Binding.Register(app);
            System_IO_FileStream_Binding.Register(app);
            UnityEngine_AssetBundles_ABLoader_Binding.Register(app);
            Core_TSingleton_1_ABPlatform_Binding.Register(app);
            UnityEngine_AssetBundles_ABPlatform_Binding.Register(app);
            System_Threading_Tasks_Task_1_UnityEngine_AssetBundles_ABLoader_Binding_LoaderRequest_Binding.Register(app);
            System_Runtime_CompilerServices_TaskAwaiter_1_UnityEngine_AssetBundles_ABLoader_Binding_LoaderRequest_Binding.Register(app);
            UnityEngine_AssetBundles_ABLoader_Binding_LoaderRequest_Binding.Register(app);
            UnityEngine_TextAsset_Binding.Register(app);
            System_Collections_Generic_Stack_1_ILTypeInstance_Binding.Register(app);
            Core_LexicalAnalysis_Binding.Register(app);
            UnityEngine_Quaternion_Binding.Register(app);
            UnityEngine_Component_Binding.Register(app);
            UnityEngine_Mathf_Binding.Register(app);
            UnityEngine_Time_Binding.Register(app);
            UnityEngine_Physics_Binding.Register(app);
            UnityEngine_RaycastHit_Binding.Register(app);
            UnityEngine_LayerMask_Binding.Register(app);
            Framework_InputManager_Binding.Register(app);
            UnityEngine_Animator_Binding.Register(app);
            Core_TSingleton_1_HotfixEventManager_Binding.Register(app);
            Framework_Hotfix_HotfixEventManager_Binding.Register(app);
            Core_ICustomAttributeProviderExpand_Binding.Register(app);
            System_Reflection_CustomAttributeExtensions_Binding.Register(app);
            UnityEngine_UI_Toggle_Binding.Register(app);
            UnityEngine_UI_Text_Binding.Register(app);
            UnityEngine_UI_Toast_Binding.Register(app);
            Framework_TouchInput_Binding.Register(app);
            Framework_TouchObject_Binding.Register(app);
            UnityEngine_Screen_Binding.Register(app);
            UnityEngine_RectTransform_Binding.Register(app);
            Core_TSingleton_1_Joystick_Binding.Register(app);
            Framework_Joystick_Binding.Register(app);
            UnityEngine_UI_TextFormat_Binding.Register(app);
            System_Collections_Generic_IEnumerator_1_CKeyValuePair_2_Int32_List_1_ILTypeInstance_Binding.Register(app);
            Core_CKeyValuePair_2_Int32_List_1_ILTypeInstance_Binding.Register(app);
            System_Single_Binding.Register(app);
            System_Threading_Monitor_Binding.Register(app);
            System_InvalidOperationException_Binding.Register(app);
            System_Activator_Binding.Register(app);

            ILRuntime.CLR.TypeSystem.CLRType __clrType = null;
        }

        /// <summary>
        /// Release the CLR binding, please invoke this BEFORE ILRuntime Appdomain destroy
        /// </summary>
        public static void Shutdown(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
        }
    }
}
