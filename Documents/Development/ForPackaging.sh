#!/bin/sh
# FOR PACKAGING

# Unity Assetsフォルダにあるsamples.xdをSampleXdフォルダにコピー
echo "----- copy samples.xd -----"
cp UnityProject/Assets/I0plus/XdUnityUI/ForAdobeXD/samples.xd ./XdPlugin/SampleXd/samples.xd
echo "done.\n"

# AdobeXD developフォルダにあるプラグインソースをリポジトリに同期
echo "----- sync AdobeXD develop plugin folder. -----"
rsync -av --delete /mnt/c/Users/itouh2/AppData/Local/Packages/Adobe.CC.XD_adky2gkssdxte/LocalState/develop/XdUnityUIExport/ ./XdPlugin/XdUnityUIExport/
echo "done.\n"

# リポジトリ内から AdobeXDプラグインファイルを作成する
echo "----- make AdobeXD plugin .xdx file. -----"
(cd ./XdPlugin && zip -r XdUnityUIExport.xdx XdUnityUIExport)
echo "done.\n"

# AdobeXDプラグインをUnityプロジェクト内にコピーする
echo "----- copy .xdx file to Unity Assets. -----"
cp ./XdPlugin/XdUnityUIExport.xdx ./UnityProject/Assets/I0plus/XdUnityUI/ForAdobeXD/XdUnityUIExport.xdx
echo "done.\n"
