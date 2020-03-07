# XdUnityUI

![introduction](https://user-images.githubusercontent.com/20549024/75539439-8e0e9480-5a5d-11ea-8f92-520e6f7b0b3e.gif)

## Language
- [日本語](README_JP.md)
- [English (Machine Translation)](README.md)

## Overview

- Convert AdobeXD artboards to UI Prefab for Unity.
    - Convert AdobeXD responsive parameters to Unity RectTransform
- [GitHub](https://github.com/itouh2-i0plus/XdUnityUI)

### sample

|| AdobeXD | Unity |
| --- | --- | --- |
|Image switch button| <img src = "https://user-images.githubusercontent.com/20549024/76143694-f47a5f00-60bc-11ea-885f-ec28c2f61454.PNG" width = "300" height = " auto "/> | <img src ="https://user-images.githubusercontent.com/20549024/76143630-5dada280-60bc-11ea-8121-45d24aa03601.gif" width="500" height="auto" /> |
| Dialog| <img src = "https://user-images.githubusercontent.com/20549024/76143695-f5ab8c00-60bc-11ea-8cdb-8002f8765cd9.PNG" width = "300" height = "auto" /> | <img src = "https://user-images.githubusercontent.com/20549024/76143631-5e463900-60bc-11ea-9698-975443962aa5.gif" width = "500" height = "auto" /> |
| Vertical scroll list| <img src = "https://user-images.githubusercontent.com/20549024/76143701-f6dcb900-60bc-11ea-98bd-0d49d8a6d77d.png" width = "300" height = " auto "/> | <img src ="https://user-images.githubusercontent.com/20549024/76143628-5d150c00-60bc-11ea-9a93-9541c55e8190.gif" width="500" height="auto" /> |
| Character input| <img src = "https://user-images.githubusercontent.com/20549024/76143696-f5ab8c00-60bc-11ea-9d8f-9acf72188b8e.PNG" width = "300" height = "auto "/> | <img src ="https://user-images.githubusercontent.com/20549024/76143624-5ab2b200-60bc-11ea-820a-b25755c6433c.gif" width="500" height="auto" /> |
| Toggle radio button| <img src="https://user-images.githubusercontent.com/20549024/76143700-f6dcb900-60bc-11ea-9ea3-4af279919544.PNG" width = "300" height = "auto" /> | <img src = "https://user-images.githubusercontent.com/20549024/76143627-5c7c7580-60bc-11ea-8a86-ae4890365330.gif" width = "500" height = "auto" /> |
| Scroll| <img src = "https://user-images.githubusercontent.com/20549024/76143697-f6442280-60bc-11ea-9214-00ca42075c22.PNG" width = "300" height = "auto" /> | <img src = "https://user-images.githubusercontent.com/20549024/76143626-5be3df00-60bc-11ea-8236-0838d1e575b0.gif" width = "500" height = "auto" /> |
| Text window| <img src = "https://user-images.githubusercontent.com/20549024/76143702-f7754f80-60bc-11ea-8c02-9cf9b46b77f2.PNG" width = "300" height = "auto "/> | <img src ="https://user-images.githubusercontent.com/20549024/76143629-5dada280-60bc-11ea-80d5-541f8d97317a.gif" width="500" height="auto" /> |


## Installation

 - When downloading
     1. https://github.com/itouh2-i0plus/XdUnityUI/releases
     1. Click the latest version of “▶ Assets” to download XdUnityUI.unitypackage.
     1. Import XdUnityUI.unitypackage into Unity.
     1. /Assets/I0plus/XdUnityUI folder is created.
     1. Install AdobeXD plugin.
        - Double-click /Assets/I0plus/XdUnityUI/ForAdobeXD/XdUnityUIExport.xdx.
 - When cloning from a Git repository
    1. Clone the Git repository
        - https://github.com/itouh2-i0plus/XdUnityUI
            - LFS is used. Some Git clients require configuration.
     1. Open (Clone folder)/UnityProject in Unity
            - Plug-in folder below Assets/I0plus/XdUnityUI
            - Currently a Unity2019.3, UniversalRenderPipeline project.
     1. Install AdobeXD plugin
        - Double-click /Assets/I0plus/XdUnityUI/ForAdobeXD/XdUnityUIExport.xdx.

## quick start

1. Open AdobeXD sample
     - Located in /Assets/I0plus/XdUnityUI/ForAdobeXD/samples.xd.

1. Launch AdobeXD plugin
     1. In the artboard TestButton, select the layer immediately below the root (for example, yellow-button).
        - This operation is always required for this plugin.
        - Reference: [Edit Context rules · Adobe XD Plugin Reference](https://adobexdplatform.com/plugin-docs/reference/core/edit-context.html)
     1. From the plugin menu, click "XdUnityUI export plugin" to launch.
     1. "Folder" is the output folder. Select (Cloned folder)/UnityProject/I0plus/XdUnityUI/Import folder.
     1. Click Export.
        -Please refer to this article "When a problem occurs" regarding the case where an error occurs during output.

1. Unity conversion
     - The conversion will start when the Unity window is activated.
     - The created Prefab is placed in Assets/I0plus/CreatedPrefabs.
     - The created UI image is placed in Assets/I0plus/CreatedSprites.
         - Slice processing.
     - Place the resulting Prefab under Canvas.

## ChangeLog

### [v0.5]-2020-03-07
- Improved InputField conversion
- README_JP.md sample image added

### [v0.4]-2020-03-04
- README.md English translation
- XD plug-in English supported

### [v0.3.2]-2020-03-03

- Sample correction
- README.md modified/appended
- Modified XdPlugin/main.js comment

### [v0.3.1]-2020-03-02

- Added TextMeshPro sample and revised description
- Added Button sample
- Toggle Sample addition
- Modified README.md

### [v0.3]-2020-03-01

- Create unitypackage
- Added installation method from unitypackage

## Operating conditions

- Developed on Windows.
    - Operation verification on Mac is currently insufficient.
- Developed on Unity2019.3.
- AdobeXD has been tested with the latest version.
    - Version: 27.1.12.4

## About conversion

### Overview

- Conversion rules are applied to AdobeXD layer names.
    - Conversion rules are defined by CSS.
    - A json file and an image file are output.
    - The output image is sliced ​​unless otherwise specified.
- The conversion process in Unity is performed by writing the output file to the Unity project, XdUnityUI/Import folder.
- Prefab and Sprite are output to the specified folder.


### Rule description

- The function on Unity is determined by the AdobeXD layer name.

#### image

- Examples

    ```
    image
    window-image
    icon-image
    ```

- Description
    - If a layer or group layer has the above name, an image is created by combining the layer and the child layer, and an Image component is added on Unity.
- Note
    - The child layer is converted to an image, so the child layer is not converted.

#### button

- Examples
    ```
    button
    start-button
    back-button
    ```
- Description
    - A button component is added on Unity.
- Note
    - The child layer needs an image layer.

#### text

- Examples

    ```
    text
    title-text
    name-text
    ```

- Description
    - By giving the text layer a name like the above, a text component will be added on Unity.
- Note
    - The font used in AdobeXD must exist in the Unity project, under Assets/I0plus/XdUnityUI/Fonts /, in .ttf or .otf.
    - There is a design difference between AdobeXD and Unity. (Example: kerning)

#### textmp

- Examples

    ```
    textmp
    title-textmp
    name-textmp
    ```

- Description
    - TextMeshPro component is added on Unity by giving the text layer the name as above.
- Note
    - TMP_PRESENT is required in Project Settings> Player> Scripting Define Symbols.
    - The font used in AdobeXD must be in the Unity project, under Assets/I0plus/XdUnityUI/Fonts /, and a TextMeshPro font asset is required.
        - Example: AdobeXD uses Open Sans font Regular
            - Find the TextMeshPro font, file name "Open Sans-Regular SDF.asset".
    - There is a design difference between AdobeXD and Unity. (Example: kerning)

#### .viewport-layout-y
- Description
    - Scrollable vertical layout.
    - Refer to samples.xd VerticalListSample artboard. (With scroll bar)
    - <img src = "https://user-images.githubusercontent.com/20549024/75763061-ff608700-5d7e-11ea-985c-88feb3a2de70.png" width = "30%">
    - Will be added

- Will be added
    - scrollbar
    - toggle

## When a problem occurs

### Running AdobeXD plugin

#### Image export fails

- Cause
    - It may be a problem on AdobeXD. under investigation.
- Countermeasures
    1. Select a layer and operate the image output.
    1. Select the XdUnityUI/Import folder as the output destination and check if the output is disabled.
    1. Change the folder and output images.
    1. Output to the Import folder again.
    1. If the above is successful, the output from the plugin will also be successful.

### Unity conversion in progress

#### Conversion process is not executed

- Cause

    - When overwriting the file after the failure, Unity cannot detect the file update.

- Correspondence
    - Delete files other than \_XdUnityUIImport and \_XdUnityUIImport.meta files in XdUnityUI/Import.
    - Export again.


#### Conversion fails when trying to handle characters (Text, TextMeshPro)

- Cause
    - There may be no font.
- Countermeasures
    - The name of the font file that could not be found while trying to find it in the Console is output.
    - If necessary, rename the font file and copy it to the XdUnityUI/Fonts directory (the directory where the \_XdUnityUIFonts file is located).
    
#### TextMeshPro error is output
- Cause
    - Missing TMP_PRESENT in Scripting Define Symbols.
- Countermeasures
    - Add TMP_PRESENT to Project Settings> Player> Scripting Define Symbols.
        - TMP_PRESENT may not be added even after installing TextMeshPro package. (v3.0? unconfirmed)

### Conversion result

#### Responsive parameters are not converted correctly

- Cause 1
    - "Change responsive size" on the artboard is not turned on.
- Measure 1
    - Select the artboard and turn on "Layout"> "Change responsive size".
- Cause 2
    - When executing the AdobeXD plug-in, the size of the artboard is changed and the responsive parameter is obtained by checking the change in the size of the layer. At that time, the responsive parameter cannot be determined for those whose size does not change, such as the layer in the repeated grid.
- Measure 2
    - Use the margin-fix property and specify it explicitly.
        - Example: start-button {margin-fix: t b l r}
    - AdobeXD Plugin API will support if responsive parameters can be obtained.

#### I don't need the background image component
- Cause
    - Artboard background is set.
- Countermeasures
    - Select the artboard and uncheck "Appearance"> "Fill".

## For better use

### Original conversion rules

- Edit conversion rule CSS
    - When changing the XDX file
        1. Rename XdUnityUIExport.xdx to XdUnityUIExport.zip
        1. Unzip and edit xd-unity.css file
        1. Zip again, change the extension to xdx
        1. Reinstall plugin
    - When deploying to the AdobeXD development folder
        1. Uninstall XdUnityUI export plugin
        1. Rename XdUnityUIExport.xdx to XdUnityUIExport.zip
        1. Unzip and copy the folder to the AdobeXD development folder (Plug-in> Development version> Display development folder)
        1. Edit xd-unity.css
        1. Reload the plugin (Plugin> Development> Reload)
- Explanation of conversion rule CSS
    - Will be added
- Conversion rules for each artboard
    - Will be added

### Add your own components when converting

- Will be added

### 9Slice

- Will be added

## Future directions

- Goal
    - Enable UI design with AdobeXD until release.
- merit
    - Hold the final version in the hands of the designer.
    - Use CCLibrary to link with various tools.
- Task
    - Work done on Prefabs (adding components and adjusting parameters on Unity) is lost by overwriting Prefabs during conversion.
        - counter-measure
            - Copy and use.
            - Evacuation of additional work in Prefab Variant.
                - Work disappears due to name change.
                - Some work remains in the Variant file (we are investigating whether it can be restored).
    - Too many same Sprite images.
        - During correspondence
            - We are developing a tool to compare Sprite images and combine them if they are the same.
    - 9Slice
        - During correspondence
    - Component state
        - https://helpx.adobe.com/jp/xd/help/create-component-states.html
        - If it can be obtained by AdobeXD Plugin API, it will be supported.
- Other
    - investigating
        - Can you convert to UXML?
        - Can the UI for DOTS mode be created?

## Acknowledgments

- @kyubuns (https://kyubuns.dev)
- Baum2 (https://github.com/kyubuns/Baum2)

### Thank you very much