<div align="center">

# ⚡ PWA Converter

**A powerful, logic-driven desktop application to instantly transform any standard HTML website into a fully functional Progressive Web App (PWA).**

[![Follow on GitHub](https://img.shields.io/github/followers/Ahm3dRamad3n?label=Follow&style=social)](https://github.com/Ahm3dRamad3n)
[![Connect on LinkedIn](https://img.shields.io/badge/Connect-LinkedIn-0077B5?style=social&logo=linkedin)](https://www.linkedin.com/in/ahm3d-ramadan/)
<br>
[![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)]()
[![.NET Framework](https://img.shields.io/badge/.NET_Framework-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)]()
[![WinForms](https://img.shields.io/badge/Windows_Forms-0078D4?style=for-the-badge&logo=windows&logoColor=white)]()

</div>

---

## 📌 Overview

**PWA Converter** eliminates the manual hassle of writing Service Workers and Manifest files. Designed with a clean, intuitive Graphical User Interface (GUI), this tool allows developers to generate all necessary PWA assets for a new web project or seamlessly update the configuration of an existing PWA—all without writing a single line of JSON.

---

## ✨ Key Features

* 🔄 **Dual Modes (Generate & Modify):** Choose to generate a fresh PWA from a plain HTML file, or load an existing project to safely modify its properties.
* 🗂️ **Interactive Folder Tree View:** Visually inspect your project's directory structure directly within the app before applying any modifications.
* 🎨 **Full Customization:** Easily configure essential PWA properties such as App Name, Short Name, Start URL, Theme Colors, Background Color, and Display Mode.
* ⚙️ **Service Worker Management:** Add, remove, or manage custom Service Worker (`sw.js`) scripts through a dedicated UI control.
* 💉 **Smart Code Injection:** Automatically injects the required Service Worker registration script and `<meta>` tags directly into your HTML files.
* 🖼️ **Icon Organization:** Select and link required app icons to ensure a native-like installation experience on all platforms.

---

## 🚀 Installation & Deployment

You don't need to compile the source code to use the app. Follow these simple steps:

1.  Navigate to the **[Releases](https://github.com/Ahm3dRamad3n/PWA_Converter/releases)** section of this repository.
2.  Download the latest version of `PWA Converter.exe`.
3.  Run the application directly (Portable version - No installation required).
    * *Note: Ensure you have the .NET Framework installed on your Windows machine.*

---

## 🛠️ Technical Details

This tool is built on a solid foundation of **Pure Logic** and efficient file processing:
* **Language/Platform:** C# / .NET Framework
* **User Interface:** Windows Forms (WinForms)
* **Data Handling:** `Newtonsoft.Json` for robust serialization of the manifest file.
* **Core Engine:** A custom `PWAProcessor` class engineered for precise File I/O operations and logic-driven text manipulation.

---

## 📄 License

This project is open-source and available under the **MIT License**.
