# Windows-OCR-Test

[![MIT License](https://img.shields.io/github/license/mson0129/telegram_bot)](https://www.mit.edu/~amini/LICENSE.md)
![Repo Size](https://img.shields.io/github/repo-size/mson0129/Windows-OCR-Test)
![Last Commit](https://img.shields.io/github/last-commit/mson0129/Windows-OCR-Test)
![Release Version](https://img.shields.io/github/v/release/mson0129/Windows-OCR-Test)
[![Hits](https://hits.seeyoufarm.com/api/count/incr/badge.svg?url=https%3A%2F%2Fgithub.com%2Fmson0129%2FWindows-OCR-Test&count_bg=%2379C83D&title_bg=%23555555&icon=&icon_color=%23E7E7E7&title=hits&edge_flat=false)](https://hits.seeyoufarm.com)

![.NET Core](https://img.shields.io/badge/.NET%20Core-v3.1-blue)

Windows 11 한국어 광학 인식(Korean OCR) 테스트를 위한 CLI 프로그램입니다.

[남정현님의 아티클](https://velog.io/@rkttu/csharp-win10-ocr-howto)을 참고하여, CLI 기반으로 이미지 경로 전달 시 OCR 처리를 할 수 있도록 하였습니다.

Visual Studio 2019 Community Edition으로 프로젝트 생성 및 개발하였습니다.

## 사용방법

cs_ocr.exe image-file-path.jpg

## 테스트 후기

인식 성능은 오픈소스인 Tesseract보다 좋았으나, 카카오 OCR API 등 AI 기반의 온라인 API보다 성능이 떨어졌습니다.

# 참조(References)
* [C#으로 Windows 10 OCR 사용하기](https://velog.io/@rkttu/csharp-win10-ocr-howto)

    * 본 프로젝트에 근간이 되는 아티클입니다. 예제 코드에 namespace와 CLI arguments를 통한 인식용 이미지 경로 전달 부분만 추가하였습니다.
