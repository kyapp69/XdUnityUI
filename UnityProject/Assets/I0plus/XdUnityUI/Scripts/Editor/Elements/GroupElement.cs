using System;
using System.Collections.Generic;
using System.Reflection;
#if ODIN_INSPECTOR
using Sirenix.Utilities;
#endif
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;

namespace XdUnityUI.Editor
{
    /// <summary>
    /// GroupElement class.
    /// based on Baum2.Editor.GroupElement class.
    /// </summary>
    public class GroupElement : Element
    {
        protected readonly List<Element> Elements;
        private Area _areaCache;
        private Dictionary<string, object> _canvasGroupParam;
        protected Dictionary<string, object> LayoutParam;
        protected Dictionary<string, object> ContentSizeFitterParam;
        protected Dictionary<string, object> LayoutElementParam;
        protected bool? RectMask2DParam;
        protected string FillColorParam;
        protected Dictionary<string, object> addComponentJson;
        protected List<object> componentsJson;

        public GroupElement(Dictionary<string, object> json, Element parent, bool resetStretch = false) : base(json,
            parent)
        {
            Elements = new List<Element>();
            var jsonElements = json.Get<List<object>>("elements");
            foreach (var jsonElement in jsonElements)
            {
                Elements.Add(ElementFactory.Generate(jsonElement as Dictionary<string, object>, this));
            }

            Elements.Reverse();
            _areaCache = CalcAreaInternal();
            _canvasGroupParam = json.GetDic("canvas_group");
            LayoutParam = json.GetDic("layout");
            ContentSizeFitterParam = json.GetDic("content_size_fitter");
            LayoutElementParam = json.GetDic("layout_element");
            RectMask2DParam = json.GetBool("rect_mask_2d");
            FillColorParam = json.Get("fill_color");
            addComponentJson = json.GetDic("add_component");
            componentsJson = json.Get<List<object>>("components");
        }

#if ODIN_INSPECTOR
        public static Tuple<MemberInfo, object, Type> GetProperty(Type type, object target, string propertyPath)
        {
            // 参考サイト：　https://stackoverflow.com/questions/366332/best-way-to-get-sub-properties-using-getproperty
            // 配列、Dictionaryへのアクセスも考慮してある
            try
            {
                if (string.IsNullOrEmpty(propertyPath))
                    return null;
                string[] splitter = {"."};
                var sourceProperties = propertyPath.Split(splitter, StringSplitOptions.None);

                //TODO: さすがにfor内に入れるべき
                var infos = type.GetMember(sourceProperties[0]);
                if (infos.Length == 0) return null;
                type = infos[0].GetReturnType();
                var targetHolder = target;
                target = infos[0].GetMemberValue(target);

                // ドットで区切られたメンバー名配列で深堀りしていく
                for (var x = 1; x < sourceProperties.Length; ++x)
                {
                    infos = type.GetMember(sourceProperties[x]);
                    if (infos.Length == 0) return null;
                    type = infos[0].GetReturnType();
                    targetHolder = target;
                    target = infos[0].GetMemberValue(target);
                    var atyperef = __makeref(targetHolder);
                }

                // 値の変更方法
                // Item1.SetMemberValue(Item2, "Cartoon Blip"); 
                return new Tuple<MemberInfo, object, Type>(infos[0], targetHolder, type);
            }
            catch
            {
                throw;
            }
        }

        public static object SetProperty(Type targetType, object targetValue, string propertyPath,
            List<object> strData)
        {
            // 参考サイト：　https://stackoverflow.com/questions/366332/best-way-to-get-sub-properties-using-getproperty
            // 配列、Dictionaryへのアクセスも考慮してある
            try
            {
                if (string.IsNullOrEmpty(propertyPath))
                    return null;
                string[] splitter = {"."};
                var memberNames = propertyPath.Split(splitter, StringSplitOptions.None);

                //MemberInfo[] memberInfos;
                var nextTargetValue = targetValue;
                MemberInfo memberInfo = null;
                //object memberValue = null;

                // ドットで区切られたメンバー名配列で深堀りしていく
                foreach (var memberName in memberNames)
                {
                    targetValue = nextTargetValue;
                    var memberInfos = targetType.GetMember(memberName);
                    if (memberInfos.Length == 0) return null;
                    memberInfo = memberInfos[0];
                    var memberType = memberInfo.GetReturnType();
                    var memberValue = memberInfo.GetMemberValue(targetValue);
                    // next
                    nextTargetValue = memberValue;
                    targetType = memberType;
                }

                object value; // セットする値
                var firstStrData = strData[0] as string;
                var firstStrDataLowerCase = firstStrData.ToLower();
                if (targetType == typeof(bool))
                {
                    value = firstStrDataLowerCase != "0" && firstStrDataLowerCase != "false" &&
                            firstStrDataLowerCase != "null";
                }
                else if (targetType == typeof(string))
                {
                    value = firstStrData;
                }
                else if (targetType == typeof(float))
                {
                    value = float.Parse(firstStrData);
                }
                else if (targetType == typeof(double))
                {
                    value = double.Parse(firstStrData);
                }
                else if (targetType == typeof(Vector3))
                {
                    if (strData.Count >= 3)
                    {
                        var x = float.Parse(strData[0] as string);
                        var y = float.Parse(strData[1] as string);
                        var z = float.Parse(strData[2] as string);
                        value = new Vector3(x, y, z);
                    }
                    else
                    {
                        value = new Vector3(0, 0, 0);
                        Debug.LogError("Vector3を作成しようとしたが入力データが不足していた");
                    }
                }
                else
                {
                    // enum値などこちら
                    value = int.Parse(firstStrData);
                }

                memberInfo.SetMemberValue(targetValue, value);

                return value;
            }
            catch
            {
                throw;
            }
        }

        public static void SetupAddComponent(GameObject go, Dictionary<string, object> json)
        {
            if (json == null) return;
            var typeName = json.Get("type_name");
            if (typeName == null)
                return;
            var type = Type.GetType(typeName);
            if (type == null)
            {
                Debug.LogError($"Baum2 error*** Type.GetType({typeName})failed.");
                return;
            }

            var component = go.AddComponent(type);
        }
#endif

        public List<Tuple<GameObject, Element>> RenderedChildren { get; private set; }

        public override GameObject Render(Renderer renderer, GameObject parentObject)
        {
            var go = CreateSelf(renderer);
            var rect = go.GetComponent<RectTransform>();
            if (parentObject)
            {
                //親のパラメータがある場合､親にする 後のAnchor定義のため
                rect.SetParent(parentObject.transform);
            }

            RenderedChildren = RenderChildren(renderer, go);
            ElementUtil.SetupCanvasGroup(go, _canvasGroupParam);
            ElementUtil.SetupChildImageComponent(go, RenderedChildren);
            ElementUtil.SetupFillColor(go, FillColorParam);
            ElementUtil.SetupContentSizeFitter(go, ContentSizeFitterParam);
            ElementUtil.SetupLayoutGroup(go, LayoutParam);
            ElementUtil.SetupLayoutElement(go, LayoutElementParam);
            ElementUtil.SetupComponents(go, componentsJson);

            SetAnchor(go, renderer);
            return go;
        }


        protected virtual GameObject CreateSelf(Renderer renderer)
        {
            var go = CreateUIGameObject(renderer);

            var rect = go.GetComponent<RectTransform>();
            var area = CalcArea();
            //rect.sizeDelta = area.Size;
            //rect.anchoredPosition = renderer.CalcPosition(area.Min, area.Size);

            SetMaskImage(renderer, go);
            return go;
        }

        protected void SetMaskImage(Renderer renderer, GameObject go)
        {
            var maskSource = Elements.Find(x => x is MaskElement);
            if (maskSource == null) return;

            Elements.Remove(maskSource);
            var maskImage = go.AddComponent<Image>();
            maskImage.raycastTarget = false;

            var dummyMaskImage = maskSource.Render(renderer, null);
            dummyMaskImage.transform.SetParent(go.transform);
            dummyMaskImage.GetComponent<Image>().CopyTo(maskImage);
            Object.DestroyImmediate(dummyMaskImage);

            var mask = go.AddComponent<Mask>();
            mask.showMaskGraphic = false;
        }

        protected List<Tuple<GameObject, Element>> RenderChildren(Renderer renderer, GameObject parent,
            Action<GameObject, Element> callback = null)
        {
            var list = new List<Tuple<GameObject, Element>>();
            foreach (var element in Elements)
            {
                var go = element.Render(renderer, parent);
                if (go.transform.parent != parent.transform)
                {
                    Debug.Log("親が設定されていない" + go.name);
                }

                list.Add(new Tuple<GameObject, Element>(go, element));
                callback?.Invoke(go, element);
            }

            foreach (var element in Elements)
            {
                element.RenderPass2(list);
            }

            return list;
        }

        private Area CalcAreaInternal()
        {
            var area = Area.None();
            foreach (var element in Elements) area.Merge(element.CalcArea());
            return area;
        }

        public override Area CalcArea()
        {
            return _areaCache;
        }
    }
}