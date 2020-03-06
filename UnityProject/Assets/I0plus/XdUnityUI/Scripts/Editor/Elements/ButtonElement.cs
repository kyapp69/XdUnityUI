using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;

namespace XdUnityUI.Editor
{
    /// <summary>
    /// ButtonElement class.
    /// based on Baum2.Editor.ButtonElement class.
    /// </summary>
    public sealed class ButtonElement : GroupElement
    {
        private Dictionary<string, object> _button;
        private Dictionary<string, object> _layoutElement;
        
        public ButtonElement(Dictionary<string, object> json, Element parent) : base(json, parent)
        {
            _button = json.GetDic("button");
            _layoutElement = json.GetDic("layout_element");
        }

        public override GameObject Render(Renderer renderer, GameObject parentObject)
        {
            var go = CreateSelf(renderer);
            var rect = go.GetComponent<RectTransform>();
            if (parentObject)
            {
                //親のパラメータがある場合､親にする 後のAnchor定義のため
                rect.SetParent(parentObject.transform);
            }
            var children = RenderChildren(renderer, go);

            var button = go.AddComponent<Button>();
            if (_button != null)
            {
                var type = _button.Get("transition");
                switch (type)
                {
                    case "sprite-swap":
                        button.transition = Selectable.Transition.SpriteSwap;
                        break;
                    case "color-tint":
                        button.transition = Selectable.Transition.ColorTint;
                        break;
                    case "animation":
                        button.transition = Selectable.Transition.Animation;
                        break;
                    case "none":
                        button.transition = Selectable.Transition.None;
                        break;
                    default:
                        button.transition = Selectable.Transition.ColorTint;
                        break;
                }

                var targetImage = ElementUtil.FindComponentByClassName<Image>(children, _button.Get("target_graphic_class"));
                if (targetImage != null)
                {
                    button.targetGraphic = targetImage;
                }

                var spriteStateJson = _button.GetDic("sprite_state");
                if (spriteStateJson != null)
                {
                    var spriteState = new SpriteState();
                    var image = ElementUtil.FindComponentByClassName<Image>(children, spriteStateJson.Get("highlighted_sprite_class"));
                    if (image != null)
                    {
                        spriteState.highlightedSprite = image.sprite;
                        Object.DestroyImmediate(image.gameObject);
                    }

                    image = ElementUtil.FindComponentByClassName<Image>(children, spriteStateJson.Get("pressed_sprite_class"));
                    if (image != null)
                    {
                        spriteState.pressedSprite = image.sprite;
                        Object.DestroyImmediate(image.gameObject);
                    }

                    image = ElementUtil.FindComponentByClassName<Image>(children, spriteStateJson.Get("selected_sprite_class"));
                    if (image != null)
                    {
                        spriteState.selectedSprite = image.sprite;
                        Object.DestroyImmediate(image.gameObject);
                    }

                    image = ElementUtil.FindComponentByClassName<Image>(children, spriteStateJson.Get("disabled_sprite_class"));
                    if (image != null)
                    {
                        spriteState.disabledSprite = image.sprite;
                        Object.DestroyImmediate(image.gameObject);
                    }

                    button.spriteState = spriteState;
                }
            }

            // TargetGraphicが設定されなかった場合
            if (button.targetGraphic == null)
            {
                // 子供からImage持ちを探す

                var image = go.GetComponentInChildren<Image>();
                if (image == null)
                {
                    // componentでないか探す
                    image = go.GetComponent<Image>();
                }

                button.targetGraphic = image;
            }

            SetAnchor(go, renderer);
            ElementUtil.SetupLayoutElement(go, _layoutElement);
            ElementUtil.SetupComponents(go, componentsJson);
            return go;
        }
    }
}