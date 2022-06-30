# Windows-OCR-Test

[![MIT License](https://img.shields.io/github/license/mson0129/telegram_bot)](https://www.mit.edu/~amini/LICENSE.md)
![Repo Size](https://img.shields.io/github/repo-size/mson0129/Windows-OCR-Test)
![Last Commit](https://img.shields.io/github/last-commit/mson0129/Windows-OCR-Test)
![Release Version](https://img.shields.io/github/v/release/mson0129/Windows-OCR-Test)
[![Hits](https://hits.seeyoufarm.com/api/count/incr/badge.svg?url=https%3A%2F%2Fgithub.com%2Fmson0129%2FWindows-OCR-Test&count_bg=%2379C83D&title_bg=%23555555&icon=&icon_color=%23E7E7E7&title=hits&edge_flat=false)](https://hits.seeyoufarm.com)

![.NET Core](https://img.shields.io/badge/.NET%20Core-v3.1-blue)

Windows 10 및 Windows 11 한국어 광학 인식(Korean OCR) 테스트를 위한 CLI 프로그램입니다.

[남정현님의 아티클](https://velog.io/@rkttu/csharp-win10-ocr-howto)을 참고하여, CLI 기반으로 이미지 경로 전달 시 OCR 처리를 할 수 있도록 하였습니다.

Visual Studio 2019 Community Edition으로 프로젝트 생성 및 개발하였습니다.

## 빌드방법

1. Visual Studio 2019 버전 이상을 설치합니다.

2. .NET 4.0 및 .NET Core 3.1을 설치합니다.

3. 솔루션 프로젝트 파일을 엽니다. (cs_ocr.sln)

4. 솔루션 탐색기의 종속성 항목을 우클릭하여 프로젝트 참조를 수정합니다.  
![ref](https://user-images.githubusercontent.com/8183993/176567359-d35d23a8-b7bd-4068-8407-7288fbf62804.png)

    1. System.Runtime.WindowsRuntime.dll 파일  
    %windir%\Microsoft.NET\Framework64\v4.0.30319\System.Runtime.WindowsRuntime.dll
    
    2. Windows.winmd 파일  
    %programfiles(x86)%\Windows Kits\10\UnionMetadata\10.0.19041.0\Windows.winmd
    또는 %programfiles(x86)%\Windows Kits\10\UnionMetadata\10.0.22000.0\Windows.winmd

5. 솔루션 빌드 구성을 Release로 선택합니다.

6. 솔루션을 정리하고 빌드(Ctrl + Shift + B)합니다.

## 사용방법

cs_ocr.exe image-file-path.jpg

![ocr](https://user-images.githubusercontent.com/8183993/176492621-c1174c22-4230-4622-bbf9-1b2dc869a1ab.png)

## 테스트 후기

인식 성능은 오픈소스인 Tesseract보다 좋았으나, 카카오 OCR API 등 AI 기반의 온라인 API보다는 떨어졌습니다.

# 참조(References)
* [C#으로 Windows 10 OCR 사용하기](https://velog.io/@rkttu/csharp-win10-ocr-howto)

    * 본 프로젝트에 근간이 되는 아티클입니다. 예제 코드에 namespace와 CLI arguments 등을 추가하여 OCR 대상 이미지 경로를 지정할 수 있게 수정하였습니다.
