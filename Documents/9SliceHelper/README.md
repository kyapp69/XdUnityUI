# XdUnityUI 9Slice Helper

![9SliceHelperIntroduction](https://user-images.githubusercontent.com/20549024/77395519-1b3ad400-6de5-11ea-8b61-89b107d48ea2.gif)

## Overview

I tried to make the image 9Slice, which is often used in games, possible with AdobeXD (somehow).
It still needs to be manually configured, which will be addressed when it is possible to use the AdobeXD plugin API.

### Reference.

- 9Slice in Unity
    - https://docs.unity3d.com/ja/2018.4/Manual/9SliceSprites.html.

## How it works

- What plugins do.
    1. 9 copies of the original image.
    2. create a mask that matches the slice area.
    3. create 9 mask groups.
- Work manually.
    1. change the "Responsive Size Change" parameter.

## Install the plugin

1. https://github.com/itouh2-i0plus/XdUnityUI/releases
1. download the latest version of 9SliceHelper.xdx.
1. double-click the xdx file and install it into AdobeXD.

## How to do it

1. Import 9Slice-enabled images into AdobeXD
1. enter a sliced pixel in the layer name of the imported image.
    - Examples: top 20 pixels, right 30 pixels, bottom 10 pixels, left 40 pixels
        - ```layer-name {image-slice: 20px 30px 10px 40px}```
    - Example: top right, bottom left, same number of pixels
        - ```layer-name {image-slice: 100px}```
1. select the image and run 9SliceHelper > Make 9Slice from the plugin menu.
1. change the "Responsive Size Change" parameter of the created group as follows.
! [image.png](https://qiita-image-store.s3.ap-northeast-1.amazonaws.com/0/350704/54037def-c3ed-eb7e-257a-e1a49ee47a44.png)

## Related.
- XdUnityUI
    - 9Sliced layers can be brought to Unity with this tool.
    - GitHub
        - https://github.com/itouh2-i0plus/XdUnityUI
    - Qiita.
        - https://qiita.com/itouh2-i0plus/items/7eaf9a0a562a4573dc1c
- Adobe Forum
    - Requests to 9slice on the forum
        - https://adobexd.uservoice.com/forums/353007-adobe-xd-feature-requests/suggestions/18521113-9-slice-scaling-of-bitmaps
        - Designing in bitmap over AdobeXD may not be much of an effort

## future
I'd like to do more and more things that make game production easier using Adobe XD.

