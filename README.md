# TouchPrtSc

タブレットモードだとキーボード押せない→スクリーンショットのショートカットキーも押せない←どうにかしたい  

ならスクリーンショットのショートカットキーを押すアプリを作ればええやん←つくった。これ

![Imgur](https://imgur.com/AyttNrS.png)

# 使い方
左から、

- 移動用のボタン（？）
    - 移動用のボタンの部分を長押しすることで移動できます。
- スクリーンショットボタン
- 終了ボタン

# 使用例

![Imgur](https://imgur.com/ukEHgS3.png)

ゲームエンジンによっては使えないかもしれない。

# ダウンロード

`.NET 5`が必要です。  

https://dotnet.microsoft.com/download/dotnet/5.0/runtime?utm_source=getdotnetcore&utm_medium=referral

からダウンロードしてください。Desktop Runtime の方です。

その後このアプリをダウンロードしてください。多分GitHubのReleaseにあります。

# 仕組み
`Windowsキー`+`PrintScreenキー`を押す操作を`WindowsAPI`の`SendInput`関数を`C#`から操作できるようにした。

`SendScreenShotKeyCode.cs`がキーボードを押す操作をしている部分、`WindowsAPISendInput.cs`が`WindowsAPIのSendInput`関数を`C#`から操作できるようにしたものです。

# オープンソースライセンス
ありがとうございます。

```
Templarian/MaterialDesign

# Icons: Apache 2.0 (https://www.apache.org/licenses/LICENSE-2.0)
Some of the icons are redistributed under the Apache 2.0 license. All other
icons are either redistributed under their respective licenses or are
distributed under the Apache 2.0 license.

---

ElinamLLC/SharpVectors

BSD 3-Clause License

Copyright (c) 2010 - 2018, Elinam LLC All rights reserved.

Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:

Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer.

Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.

Neither the name of the copyright holder nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
```
