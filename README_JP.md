# <img src="https://user-images.githubusercontent.com/20549024/76211417-8616d780-6249-11ea-8e94-2f337664f595.gif" width=25> XdUnityUI - AdobeXD to Unity UI

![introduction](https://user-images.githubusercontent.com/20549024/76156453-0f40e800-613e-11ea-9923-59554aceae3c.gif)

## 言語

- [日本語](README_JP.md)
- [English](README.md)

## 概要

- AdobeXD アートボードを Unity UI Prefab にコンバートします。

## サンプル

### Dots Scrollbar/ Horizontal layout scroll

|AdobeXD|Unity|
|---|---|
| <img src = "https://user-images.githubusercontent.com/20549024/76518275-27986600-64a2-11ea-9292-e3d058bf2468.png" width = "300" height = " auto "/> | <img src ="https://user-images.githubusercontent.com/20549024/76518784-12700700-64a3-11ea-9407-9bca8449b070.gif" width="500" height="auto" /> |

### 画像切替ボタン

|AdobeXD|Unity|
|---|---|
| <img src="https://user-images.githubusercontent.com/20549024/76143694-f47a5f00-60bc-11ea-885f-ec28c2f61454.PNG" width="300" height="auto"/> | <img src="https://user-images.githubusercontent.com/20549024/76143630-5dada280-60bc-11ea-8121-45d24aa03601.gif" width="500" height="auto"/> |

### ダイアログ

|AdobeXD|Unity|
|---|---|
| <img src="https://user-images.githubusercontent.com/20549024/76143695-f5ab8c00-60bc-11ea-8cdb-8002f8765cd9.PNG" width="300" height="auto"/> | <img src="https://user-images.githubusercontent.com/20549024/76143631-5e463900-60bc-11ea-9698-975443962aa5.gif" width="500" height="auto"/> |

### 縦スクロールリスト

|AdobeXD|Unity|
|---|---|
| <img src="https://user-images.githubusercontent.com/20549024/76143701-f6dcb900-60bc-11ea-98bd-0d49d8a6d77d.png" width="300" height="auto"/> | <img src="https://user-images.githubusercontent.com/20549024/76143628-5d150c00-60bc-11ea-9a93-9541c55e8190.gif" width="500" height="auto"/> |

### 文字入力

|AdobeXD|Unity|
|---|---|
| <img src="https://user-images.githubusercontent.com/20549024/76143696-f5ab8c00-60bc-11ea-9d8f-9acf72188b8e.PNG" width="300" height="auto"/> | <img src="https://user-images.githubusercontent.com/20549024/76143624-5ab2b200-60bc-11ea-820a-b25755c6433c.gif" width="500" height="auto"/> |

### トグル/ラジオボタン

|AdobeXD|Unity|
|---|---|
| <img src="https://user-images.githubusercontent.com/20549024/76143700-f6dcb900-60bc-11ea-9ea3-4af279919544.PNG" width="300" height="auto"/> | <img src="https://user-images.githubusercontent.com/20549024/76143627-5c7c7580-60bc-11ea-8a86-ae4890365330.gif" width="500" height="auto"/> |

### スクロール

|AdobeXD|Unity|
|---|---|
| <img src="https://user-images.githubusercontent.com/20549024/76143697-f6442280-60bc-11ea-9214-00ca42075c22.PNG" width="300" height="auto"/> | <img src="https://user-images.githubusercontent.com/20549024/76143626-5be3df00-60bc-11ea-8236-0838d1e575b0.gif" width="500" height="auto"/> |

### テキストウィンドウ

|AdobeXD|Unity|
|---|---|
| <img src="https://user-images.githubusercontent.com/20549024/76143702-f7754f80-60bc-11ea-8c02-9cf9b46b77f2.PNG" width="300" height="auto"/> | <img src="https://user-images.githubusercontent.com/20549024/76143629-5dada280-60bc-11ea-80d5-541f8d97317a.gif" width="500" height="auto"/> |

## インストール

- ダウンロードする場合
  1. https://github.com/itouh2-i0plus/XdUnityUI/releases
  1. 最新バージョンの 「▶Assets」をクリックし XdUnityUI.unitypackage をダウンロードします。
  1. XdUnityUI.unitypackage を Unity にインポートしてください。
  1. /Assets/I0plus/XdUnityUI フォルダが作成されます
  1. AdobeXD プラグインをインストール
     - /Assets/I0plus/XdUnityUI/ForAdobeXD/XdUnityUIExport.xdx をダブルクリックします。
- Git リポジトリからクローンする場合
  1. Git リポジトリをクローン
        - https://github.com/itouh2-i0plus/XdUnityUI
          - LFS を利用しています。Git クライアントによっては設定が必要となります。
  1. (クローンフォルダ)/UnityProject を Unity で開きます
        - Assets/I0plus/XdUnityUI 以下が、プラグインフォルダになっています
        - 現在 Unity2019.3、UniversalRenderPipeline のプロジェクトとなっています。
  1. AdobeXD プラグインをインストール
        - /Assets/I0plus/XdUnityUI/ForAdobeXD/XdUnityUIExport.xdx をダブルクリックします。

## クイックスタート

1. AdobeXD サンプルを 開く
    - /Assets/I0plus/XdUnityUI/ForAdobeXD/samples.xd にあります。

1. AdobeXD プラグイン起動
    1. アートボード TestButton 内、ルート直下のレイヤー(例えば yellow-button)を選択状態にします。 - 当プラグインは出力時にこの操作が必ず必要になります。 - 参考：[Edit Context rules · Adobe XD Plugin Reference](https://adobexdplatform.com/plugin-docs/reference/core/edit-context.html)
    1. プラグインメニューから、「XdUnityUI export plugin」をクリック、起動します。
    1. 「Folder」の項目が出力フォルダ先指定です。(クローンしたフォルダ)/UnityProject/I0plus/XdUnityUI/Import フォルダを選択。
    1. 「Export」をクリック。 - 出力時にエラーで止まるケースについて、当記事「問題が起こったとき」を参考にしてください。

1. Unity コンバート
    - Unity ウィンドウをアクティブにするとコンバートが開始されます。
    - 作成された Prefab は Assets/I0plus/CreatedPrefabs に配置されます。
    - 作成された UI 画像は Assets/I0plus/CreatedSprites に配置されます。
      - Slice 処理されています。
    - できた Prefab を Canvas 以下に配置します。

## ChangeLog

### [v0.7.2] - 2020-03-13
- DotsScrollbarのテスト
- マスク処理の修正

<details><summary>詳細</summary><div>

### [v0.5] - 2020-03-07

- InputField 変換を整備
- README_JP.md サンプル画像追加

### [v0.4] - 2020-03-04

- README.md 英語化
- XD プラグイン 英語対応

### [v0.3.2] - 2020-03-03

- サンプル修正
- README.md 修正・追記
- XdPlugin/main.js コメント修正

### [v0.3.1] - 2020-03-02

- TextMeshPro サンプル追加、説明修正
- Button サンプル追加
- Toggle サンプル追加
- README.md 修正

### [v0.3] - 2020-03-01

- unitypackage の作成
- unitypackage からのインストール方法追記
</div></details>

## 動作条件

- Windows で開発しています。
  - Mac での動作確認は現在不十分です。
- Unity2019.3 で開発しています。
- AdobeXD は最新版でテストしています。
  - バージョン：27.1.12.4

## コンバートについて

### 概要

- AdobeXD レイヤー名に対して、コンバートルールが適応されます。
  - コンバートルールは CSS の記述によって定義されています。
  - json ファイルと画像ファイルが出力されます。
  - 出力画像は、指定が無い限りスライス処理されます。
- 出力ファイルを Unity プロジェクト、XdUnityUI/Import フォルダに書き込むことで Unity でのコンバート処理が行われます。
- 指定されたフォルダに Prefab と Sprite が出力されます。

### ルール説明

- AdobeXD レイヤー名で、Unity 上での機能が決まります。

#### image

- 例

  ```
  image
  window-image
  icon-image
  ```

- 説明
  - レイヤー、グループレイヤーに上記のような名前が付いていた場合、そのレイヤーと子レイヤーを合成した画像を生成し、Unity 上で Image コンポーネントが付与されます。
- 注意
  - 子レイヤーも画像としてしまうため、子レイヤーのコンバート処理はされません。

#### button

- 例
  ```
  button
  start-button
  back-button
  ```
- 説明
  - Unity 上で button コンポーネントが付与されます。
- 注意
  - 子レイヤーに image レイヤーが必要です。

#### text

- 例

  ```
  text
  title-text
  name-text
  ```

- 説明
  - テキストレイヤーに上記のような名前をつけることで Unity 上でも Text コンポーネントが 付与 されます。
- 注意
  - AdobeXD で使用したフォントが Unity プロジェクト内、Assets/I0plus/XdUnityUI/Fonts/以下、.ttf か.otf で存在する必要があります。
  - AdobeXD と Unity では、デザイン上の差異があります。(例：カーニング)

#### textmp

- 例

  ```
  textmp
  title-textmp
  name-textmp
  ```

- 説明
  - テキストレイヤーに上記のような名前をつけることで Unity 上でも TextMeshPro コンポーネントが 付与 されます。
- 注意
  - Project Settings > Player > Scripting Define Symbols に TMP_PRESENT が必要です。
  - AdobeXD で使用したフォントが Unity プロジェクト内、Assets/I0plus/XdUnityUI/Fonts/以下、TextMeshPro フォントアセット が必要です。
     - 例: AdobeXD で Open Sans フォント Regular を使用している場合
        - TextMeshPro フォント、ファイル名「Open Sans-Regular SDF.asset」を探します。
  - AdobeXD と Unity では、デザイン上の差異があります。(例：カーニング)

#### .viewport-layout-y

- 説明

  - スクロールできる縦方向レイアウト。
  - samples.xd VerticalListSample アートボードを参考にしてください。(スクロールバー 付き)
  - <img src="https://user-images.githubusercontent.com/20549024/75763061-ff608700-5d7e-11ea-985c-88feb3a2de70.png" width="30%">
  - 追記予定

- 追記予定
  - scrollbar
  - toggle

## 問題が起こったとき

### AdobeXD プラグイン実行中

#### 画像の書き出しに失敗する

- 原因
  - AdobeXD 上の問題かもしれません。調査中です。
- 対策
  1. レイヤーを選択し画像出力の操作をする。
  1. 出力先に XdUnityUI/Import フォルダを選択すると、出力不可になっているか確認。
  1. フォルダを変えて画像出力。
  1. 再度 Import フォルダに出力する。
  1. 上記が成功した場合、プラグインからの出力も成功するようになります。

### Unity コンバート実行中

#### コンバート処理が実行されない

- 原因

  - 失敗後のファイルへの上書きでは、Unity 側がファイルの更新を検知できないため。

- 対応
  - XdUnityUI/Import 内の\_XdUnityUIImport、\_XdUnityUIImport.meta ファイル以外を削除する。
  - もう一度エキスポートする。

#### 文字(Text、TextMeshPro)を扱おうとするとコンバートに失敗する

- 原因
  - フォントが無い可能性があります。
- 対策
  - Console に探そうとして見つからなかったフォントファイル名が出力されます。
  - フォントファイルを場合によってはリネームして、XdUnityUI/Fonts ディレクトリ(\_XdUnityUIFonts ファイルがおいてあるディレクトリ)にコピーしてください。

#### TextMeshPro のエラーが出力される

- 原因
  - Scripting Define Symbols に TMP_PRESENT が無い。
- 対策
  - Project Settings > Player > Scripting Define Symbols に TMP_PRESENT を追記します。
     - TextMeshPro パッケージをインストールしても TMP_PRESENT が追記されない場合があるそうです。(v3.0?未確認)

### コンバート結果

#### レスポンシブパラメータが正確にコンバートされない

- 原因 1
  - アートボードの「レスポンシブサイズを変更」が ON になっていない。
- 対策 1
  - アートボードを選択し、「レイアウト」>「レスポンシブサイズを変更」を ON にしてください。
- 原因 2
  - AdobeXD プラグイン実行時、アートボードのサイズを変更しレイヤーのサイズの変化をみてレスポンシブパラメータを取得しています。その際、リピードグリッド内レイヤー等、サイズが変わらないものはレスポンシブパラメータが確定できません。
- 対策 2
  - margin-fix プロパティをつかい、明示的に指定してください。
     - 例: start-button {margin-fix: t b l r}
  - AdobeXD Plugin API で、レスポンシブパラメータが取得できるようになりましたら対応します。

#### 背景のイメージコンポーネントがいらない

- 原因
  - アートボードの背景が設定してある。
- 対策
  - アートボードを選択し、「アピアランス」>「塗り」のチェックを外してください。

## より使いこなすために

### オリジナル変換ルール

- 変換ルール CSS の編集
  - XDX ファイルを変更する場合
     1. XdUnityUIExport.xdx を XdUnityUIExport.zip とリネーム
     1. 解凍し xd-unity.css ファイルを編集する
     1. 再び ZIP 圧縮、拡張子を xdx に変更
     1. プラグイン再インストール
  - AdobeXD 開発フォルダに展開する場合
     1. XdUnityUI export プラグインをアンイストール
     1. XdUnityUIExport.xdx を XdUnityUIExport.zip とリネーム
     1. 解凍しフォルダを AdobeXD 開発フォルダ(プラグイン>開発版>開発フォルダーを表示)にコピーする
     1. xd-unity.css を編集
     1. プラグイン再読み込み(プラグイン>開発版>再読み込み)
- 変換ルール CSS の説明
  - 追記予定
- アートボード毎の変換ルール
  - 追記予定

### コンバート時に自作コンポーネントを追加する

- 追記予定

### 9Slice

- 追記予定

## 今後進む方向について

- 目標
  - リリースまで AdobeXD で UI デザインできるようにする。
- メリット
  - デザイナの手に最終版をもたせる。
  - CCLibrary を使い、各種ツールとの連携ができる。
- 課題
  - コンバートでの Prefab 上書きによって、Prefab に対して行った作業(Unity 上で行ったコンポーネント追加、パラメータ調整)が消えてしまう。
     - 対応策
        - コピーして使用する。
        - Prefab Variant で、追加作業の退避。
          - 名前の変更で作業が消えてしまう。
          - Variant ファイル内には作業分残っている模様(これを復帰できないか調査中)。
  - 9Slice
     - 対応中
  - コンポーネントのステート
     - https://helpx.adobe.com/jp/xd/help/create-component-states.html
     - AdobeXD Plugin API で取得できるようになりましたら、対応します。
- その他
  - 調査中
     - UXML へコンバートできないか。
     - DOTS モード用 UI が作成できないか。

## ライセンス

- XdUnityUIはフリーです（MITライセンス）。
- GitHub上にオープンソースとして公開しています。
     - https://github.com/itouh2-i0plus/XdUnityUI
- サンプルで使用している画像のライセンス
  - "Vector graphic for Fishdom Playrix" by Daria Volkova is licensed under [CC BY-NC-ND 4.0](https://creativecommons.org/licenses/by-nc-nd/4.0/?ref=ccsearch&atype=rich)
  - https://www.behance.net/gallery/10239443/Vector-graphic-for-Fishdom-Playrix

## サポートフォーラム

- https://forum.unity.com/threads/xdunityui-adobexd-to-unity.843730/

## 謝辞

- @kyubuns 様 (https://kyubuns.dev)
- Baum2 (https://github.com/kyubuns/Baum2)

### お世話になっております ありがとうございます

