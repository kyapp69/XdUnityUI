# XdUnityUI 9Slice Helper

![9SliceHelperIntroduction](https://user-images.githubusercontent.com/20549024/77395519-1b3ad400-6de5-11ea-8b61-89b107d48ea2.gif)

## 概要

ゲームでよくつかわれる、画像の9SliceをAdobeXDで(なんとか)できるようにしてみました。
手動での設定がまだ必要です。AdobeXD プラグインAPIで操作できるようになりましたら対応します。

### 参考

- Unityでの9Slice
    - https://docs.unity3d.com/ja/2018.4/Manual/9SliceSprites.html

## 仕組み

- プラグインがやること
    1. 元画像を9個コピー。
    2. スライス領域にあわせたマスクを作成する。
    3. マスクグループを9個作成。
- 手動で作業
    1. 「レスポンシブサイズ変更」パラメータの変更。

## プラグインのインストール

1. https://github.com/itouh2-i0plus/XdUnityUI/releases
1. 最新バージョンの9SliceHelper.xdxをダウンロードする。
1. xdxファイルをダブルクリック、AdobeXDにインストール。

## 実行方法

1. 9Slice可能な画像をAdobeXDにインポート
1. インポートした画像のレイヤー名に、スライスピクセルを入力する。
    - 例: 上 20ピクセル、右 30ピクセル、下 10ピクセル、左 40ピクセル
        - ``` layer-name {image-slice: 20px 30px 10px 40px} ```
    - 例: 上右下左、同じピクセル数
        - ```layer-name {image-slice: 100px}```
1. 画像を選択した状態で プラグインメニューより、9SliceHelper > Make 9Slice を実行。
1. できたグループの「レスポンシブサイズ変更」パラメータを以下のように変更する。
![image.png](https://qiita-image-store.s3.ap-northeast-1.amazonaws.com/0/350704/54037def-c3ed-eb7e-257a-e1a49ee47a44.png)

## 関連
- XdUnityUI
    - 9Sliceしたレイヤーを、このツールでUnityにもっていけるようにしています
    - GitHub
        - https://github.com/itouh2-i0plus/XdUnityUI
    - Qiita
        - https://qiita.com/itouh2-i0plus/items/7eaf9a0a562a4573dc1c
- Adobe Forum
    - フォーラムでの9sliceへの要求
        - https://adobexd.uservoice.com/forums/353007-adobe-xd-feature-requests/suggestions/18521113-9-slice-scaling-of-bitmaps
        - AdobeXD上ビットマップでのデザインは、あまり力をいれないのかもしれないです

## 今後
AdobeXDをつかって、ゲームの制作が楽になることはどんどんやっていきたいと思っています
