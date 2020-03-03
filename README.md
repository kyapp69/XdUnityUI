# XdUnityUI

![introduction](https://user-images.githubusercontent.com/20549024/75539439-8e0e9480-5a5d-11ea-8f92-520e6f7b0b3e.gif)

## Language
- [Japanese](README_JP.md)
- [English (Machine Translation)](README.md)

## Overview

- Convert AdobeXD artboards to UI Prefab for Unity.
- [GitHub](https://github.com/itouh2-i0plus/XdUnityUI)

## Installation

1. Installation
     - When downloading
         1. https://github.com/itouh2-i0plus/XdUnityUI/releases
         1. Click the latest version of “▶ Assets” to download XdUnityUI.unitypackage.
         1. Import XdUnityUI.unitypackage into Unity.
         1. /Assets/I0plus/XdUnityUI folder is created
         1. Install AdobeXD plugin
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

## Quick Start

1. Open AdobeXD sample
     - Located in /Assets/I0plus/XdUnityUI/ForAdobeXD/samples.xd.

1. Launch AdobeXD plugin
     1. In the artboard TestButton, select the layer immediately below the root (for example, yellow-button).
        - This operation is always required for this plugin.
        - Reference: [Edit Context rules · Adobe XD Plugin Reference](https://adobexdplatform.com/plugin-docs/reference/core/edit-context.html)
     1. From the plugin menu, click "XdUnityUI export plugin" to launch.
     1. "Folder" is the output folder. Select (Cloned folder)/UnityProject/I0plus/XdUnityUI/Import folder.
     1. Click Export. -Please refer to this article "When a problem occurs" regarding the case where an error occurs during output.

1. Unity conversion
     - The conversion will start when the Unity window is activated.
     - The created Prefab is placed in Assets/I0plus/CreatedPrefabs.
     - The created UI image is placed in Assets/I0plus/CreatedSprites.
         - Slice processing.
     - Place the resulting Prefab under Canvas.

## ChangeLog

### [v0.3.2]-2020-03-02

Sample modification
README.md Correction/addition
XdPlugin/main.js comment correction

### [v0.3.1]-2020-03-02

TextMeshPro sample added, description modified
Button sample added
Toggle Add Sample
README.md modified

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

#### .vierpot-layout-y
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
    2. Select the XdUnityUI/Import folder as the output destination, and check if the output is disabled.
    3. Change the folder and output images.
    4. Output to the Import folder again.
    5. If the above is successful, the output from the plugin will also be successful.

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
    - Missing TMP_PRESENT in Scripting Define Symbols
- Countermeasures
    - Add TMP_PRESENT to Project Settings> Player> Scripting Define Symbols.
        - TMP_PRESENT may not be added even after installing TextMeshPro package. (v3.0? unconfirmed)

### Conversion result

#### Responsive parameters are not converted correctly

- Cause 1
    - "Change responsive size" on the artboard is not ON
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
    - Artboard background set
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
    - Work done on Prefabs (adding components and adjusting parameters on Unity) is overwritten by overwriting Prefabs during conversion.
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