﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using ILRuntime.Reflection;
using ILRuntime.CLR.Utils;

namespace ILRuntime.Runtime.Generated
{
    unsafe class System_Collections_Generic_List_1_Boolean_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(System.Collections.Generic.List<System.Boolean>);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("Add", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Add_0);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.Boolean>)};
            method = type.GetMethod("AddRange", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddRange_1);
            args = new Type[]{};
            method = type.GetMethod("AsReadOnly", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AsReadOnly_2);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("BinarySearch", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BinarySearch_3);
            args = new Type[]{typeof(System.Boolean), typeof(System.Collections.Generic.IComparer<System.Boolean>)};
            method = type.GetMethod("BinarySearch", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BinarySearch_4);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean), typeof(System.Collections.Generic.IComparer<System.Boolean>)};
            method = type.GetMethod("BinarySearch", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BinarySearch_5);
            args = new Type[]{};
            method = type.GetMethod("Clear", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Clear_6);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("Contains", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Contains_7);
            args = new Type[]{typeof(System.Boolean[])};
            method = type.GetMethod("CopyTo", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CopyTo_8);
            args = new Type[]{typeof(System.Boolean[]), typeof(System.Int32)};
            method = type.GetMethod("CopyTo", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CopyTo_9);
            args = new Type[]{typeof(System.Int32), typeof(System.Boolean[]), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("CopyTo", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CopyTo_10);
            args = new Type[]{typeof(System.Predicate<System.Boolean>)};
            method = type.GetMethod("Exists", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Exists_11);
            args = new Type[]{typeof(System.Predicate<System.Boolean>)};
            method = type.GetMethod("Find", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Find_12);
            args = new Type[]{typeof(System.Predicate<System.Boolean>)};
            method = type.GetMethod("FindAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, FindAll_13);
            args = new Type[]{typeof(System.Predicate<System.Boolean>)};
            method = type.GetMethod("FindIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, FindIndex_14);
            args = new Type[]{typeof(System.Int32), typeof(System.Predicate<System.Boolean>)};
            method = type.GetMethod("FindIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, FindIndex_15);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32), typeof(System.Predicate<System.Boolean>)};
            method = type.GetMethod("FindIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, FindIndex_16);
            args = new Type[]{typeof(System.Predicate<System.Boolean>)};
            method = type.GetMethod("FindLast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, FindLast_17);
            args = new Type[]{typeof(System.Predicate<System.Boolean>)};
            method = type.GetMethod("FindLastIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, FindLastIndex_18);
            args = new Type[]{typeof(System.Int32), typeof(System.Predicate<System.Boolean>)};
            method = type.GetMethod("FindLastIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, FindLastIndex_19);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32), typeof(System.Predicate<System.Boolean>)};
            method = type.GetMethod("FindLastIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, FindLastIndex_20);
            args = new Type[]{typeof(System.Action<System.Boolean>)};
            method = type.GetMethod("ForEach", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ForEach_21);
            args = new Type[]{};
            method = type.GetMethod("GetEnumerator", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetEnumerator_22);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("GetRange", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetRange_23);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("IndexOf", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IndexOf_24);
            args = new Type[]{typeof(System.Boolean), typeof(System.Int32)};
            method = type.GetMethod("IndexOf", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IndexOf_25);
            args = new Type[]{typeof(System.Boolean), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("IndexOf", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IndexOf_26);
            args = new Type[]{typeof(System.Int32), typeof(System.Boolean)};
            method = type.GetMethod("Insert", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Insert_27);
            args = new Type[]{typeof(System.Int32), typeof(System.Collections.Generic.IEnumerable<System.Boolean>)};
            method = type.GetMethod("InsertRange", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, InsertRange_28);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("LastIndexOf", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, LastIndexOf_29);
            args = new Type[]{typeof(System.Boolean), typeof(System.Int32)};
            method = type.GetMethod("LastIndexOf", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, LastIndexOf_30);
            args = new Type[]{typeof(System.Boolean), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("LastIndexOf", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, LastIndexOf_31);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("Remove", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Remove_32);
            args = new Type[]{typeof(System.Predicate<System.Boolean>)};
            method = type.GetMethod("RemoveAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveAll_33);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("RemoveAt", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveAt_34);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("RemoveRange", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveRange_35);
            args = new Type[]{};
            method = type.GetMethod("Reverse", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Reverse_36);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("Reverse", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Reverse_37);
            args = new Type[]{};
            method = type.GetMethod("Sort", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Sort_38);
            args = new Type[]{typeof(System.Collections.Generic.IComparer<System.Boolean>)};
            method = type.GetMethod("Sort", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Sort_39);
            args = new Type[]{typeof(System.Comparison<System.Boolean>)};
            method = type.GetMethod("Sort", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Sort_40);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32), typeof(System.Collections.Generic.IComparer<System.Boolean>)};
            method = type.GetMethod("Sort", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Sort_41);
            args = new Type[]{};
            method = type.GetMethod("ToArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ToArray_42);
            args = new Type[]{};
            method = type.GetMethod("TrimExcess", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TrimExcess_43);
            args = new Type[]{typeof(System.Predicate<System.Boolean>)};
            method = type.GetMethod("TrueForAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TrueForAll_44);
            args = new Type[]{};
            method = type.GetMethod("get_Capacity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Capacity_45);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_Capacity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_Capacity_46);
            args = new Type[]{};
            method = type.GetMethod("get_Count", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Count_47);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("get_Item", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Item_48);
            args = new Type[]{typeof(System.Int32), typeof(System.Boolean)};
            method = type.GetMethod("set_Item", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_Item_49);



            app.RegisterCLRCreateDefaultInstance(type, () => new System.Collections.Generic.List<System.Boolean>());
            app.RegisterCLRCreateArrayInstance(type, s => new System.Collections.Generic.List<System.Boolean>[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);
            args = new Type[]{typeof(System.Collections.Generic.IEnumerable<System.Boolean>)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_1);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_2);

        }


        static StackObject* Add_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean item = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Add(item);

            return __ret;
        }

        static StackObject* AddRange_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.Boolean> collection = (System.Collections.Generic.IEnumerable<System.Boolean>)typeof(System.Collections.Generic.IEnumerable<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddRange(collection);

            return __ret;
        }

        static StackObject* AsReadOnly_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.AsReadOnly();

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* BinarySearch_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean item = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.BinarySearch(item);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* BinarySearch_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IComparer<System.Boolean> comparer = (System.Collections.Generic.IComparer<System.Boolean>)typeof(System.Collections.Generic.IComparer<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean item = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.BinarySearch(item, comparer);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* BinarySearch_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IComparer<System.Boolean> comparer = (System.Collections.Generic.IComparer<System.Boolean>)typeof(System.Collections.Generic.IComparer<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean item = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 count = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.BinarySearch(index, count, item, comparer);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Clear_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Clear();

            return __ret;
        }

        static StackObject* Contains_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean item = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Contains(item);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* CopyTo_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean[] array = (System.Boolean[])typeof(System.Boolean[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CopyTo(array);

            return __ret;
        }

        static StackObject* CopyTo_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 arrayIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean[] array = (System.Boolean[])typeof(System.Boolean[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CopyTo(array, arrayIndex);

            return __ret;
        }

        static StackObject* CopyTo_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 count = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 arrayIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean[] array = (System.Boolean[])typeof(System.Boolean[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CopyTo(index, array, arrayIndex, count);

            return __ret;
        }

        static StackObject* Exists_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Predicate<System.Boolean> match = (System.Predicate<System.Boolean>)typeof(System.Predicate<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Exists(match);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Find_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Predicate<System.Boolean> match = (System.Predicate<System.Boolean>)typeof(System.Predicate<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Find(match);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* FindAll_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Predicate<System.Boolean> match = (System.Predicate<System.Boolean>)typeof(System.Predicate<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.FindAll(match);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* FindIndex_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Predicate<System.Boolean> match = (System.Predicate<System.Boolean>)typeof(System.Predicate<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.FindIndex(match);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* FindIndex_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Predicate<System.Boolean> match = (System.Predicate<System.Boolean>)typeof(System.Predicate<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 startIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.FindIndex(startIndex, match);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* FindIndex_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Predicate<System.Boolean> match = (System.Predicate<System.Boolean>)typeof(System.Predicate<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 count = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 startIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.FindIndex(startIndex, count, match);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* FindLast_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Predicate<System.Boolean> match = (System.Predicate<System.Boolean>)typeof(System.Predicate<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.FindLast(match);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* FindLastIndex_18(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Predicate<System.Boolean> match = (System.Predicate<System.Boolean>)typeof(System.Predicate<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.FindLastIndex(match);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* FindLastIndex_19(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Predicate<System.Boolean> match = (System.Predicate<System.Boolean>)typeof(System.Predicate<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 startIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.FindLastIndex(startIndex, match);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* FindLastIndex_20(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Predicate<System.Boolean> match = (System.Predicate<System.Boolean>)typeof(System.Predicate<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 count = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 startIndex = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.FindLastIndex(startIndex, count, match);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* ForEach_21(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.Boolean> action = (System.Action<System.Boolean>)typeof(System.Action<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ForEach(action);

            return __ret;
        }

        static StackObject* GetEnumerator_22(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetEnumerator();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetRange_23(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 count = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetRange(index, count);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* IndexOf_24(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean item = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IndexOf(item);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* IndexOf_25(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean item = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IndexOf(item, index);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* IndexOf_26(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 count = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean item = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IndexOf(item, index, count);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Insert_27(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean item = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Insert(index, item);

            return __ret;
        }

        static StackObject* InsertRange_28(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.Boolean> collection = (System.Collections.Generic.IEnumerable<System.Boolean>)typeof(System.Collections.Generic.IEnumerable<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.InsertRange(index, collection);

            return __ret;
        }

        static StackObject* LastIndexOf_29(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean item = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.LastIndexOf(item);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* LastIndexOf_30(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean item = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.LastIndexOf(item, index);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* LastIndexOf_31(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 count = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean item = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.LastIndexOf(item, index, count);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Remove_32(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean item = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Remove(item);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* RemoveAll_33(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Predicate<System.Boolean> match = (System.Predicate<System.Boolean>)typeof(System.Predicate<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.RemoveAll(match);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* RemoveAt_34(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RemoveAt(index);

            return __ret;
        }

        static StackObject* RemoveRange_35(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 count = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RemoveRange(index, count);

            return __ret;
        }

        static StackObject* Reverse_36(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Reverse();

            return __ret;
        }

        static StackObject* Reverse_37(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 count = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Reverse(index, count);

            return __ret;
        }

        static StackObject* Sort_38(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Sort();

            return __ret;
        }

        static StackObject* Sort_39(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IComparer<System.Boolean> comparer = (System.Collections.Generic.IComparer<System.Boolean>)typeof(System.Collections.Generic.IComparer<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Sort(comparer);

            return __ret;
        }

        static StackObject* Sort_40(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Comparison<System.Boolean> comparison = (System.Comparison<System.Boolean>)typeof(System.Comparison<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Sort(comparison);

            return __ret;
        }

        static StackObject* Sort_41(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IComparer<System.Boolean> comparer = (System.Collections.Generic.IComparer<System.Boolean>)typeof(System.Collections.Generic.IComparer<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 count = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Sort(index, count, comparer);

            return __ret;
        }

        static StackObject* ToArray_42(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ToArray();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* TrimExcess_43(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.TrimExcess();

            return __ret;
        }

        static StackObject* TrueForAll_44(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Predicate<System.Boolean> match = (System.Predicate<System.Boolean>)typeof(System.Predicate<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.TrueForAll(match);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_Capacity_45(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Capacity;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_Capacity_46(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 value = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Capacity = value;

            return __ret;
        }

        static StackObject* get_Count_47(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Count;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_Item_48(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method[index];

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_Item_49(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean value = ptr_of_this_method->Value == 1;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 index = ptr_of_this_method->Value;
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.List<System.Boolean> instance_of_this_method;
            instance_of_this_method = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method[index] = value;

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new System.Collections.Generic.List<System.Boolean>();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Ctor_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IEnumerable<System.Boolean> collection = (System.Collections.Generic.IEnumerable<System.Boolean>)typeof(System.Collections.Generic.IEnumerable<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = new System.Collections.Generic.List<System.Boolean>(collection);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Ctor_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 capacity = ptr_of_this_method->Value;

            var result_of_this_method = new System.Collections.Generic.List<System.Boolean>(capacity);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
